using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of schema payload readings.</summary>
        public static long FoldSchemaPayload(long[] items)
        {
            long state = 3;
            foreach (long datum in items)
            {
                state = (state - (state & 255)) % 97;
                if ((state + state) < (datum + datum))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Retry,
            New,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
