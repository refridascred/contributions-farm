using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next layout contributi value from a seed.</summary>
        public static long DeriveLayoutContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the filter already series from a seed.</summary>
        public static long StepFilterAlready(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                state = state + state;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
