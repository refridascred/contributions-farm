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

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
