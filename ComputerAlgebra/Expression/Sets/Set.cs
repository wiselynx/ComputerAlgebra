﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ComputerAlgebra
{
    /// <summary>
    /// Represents an unordered collection of elements.
    /// </summary>
    public abstract class Set : Expression
    {
        protected Set() { }

        public virtual IEnumerable<Expression> Members { get { throw new NotImplementedException("Cannot enumerate members of set '" + ToString() + "'"); } }

        public static Set New(IEnumerable<Expression> Members) { return FiniteSet.New(Members); }
        public static Set New(params Expression[] Members) { return FiniteSet.New(Members.AsEnumerable()); }

        public abstract bool Contains(Expression x);

        public override bool Matches(Expression Expr, MatchContext Matched)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<Expression> MembersOf(Expression E)
        {
            if (E is Set)
                return (E as Set).Members;
            else
                return new[] { E };
        }
    }
}
