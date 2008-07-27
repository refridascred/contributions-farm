using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] levels)
        {
            long acc = -46;
            foreach (long reading in levels)
            {
                if (reading < (acc ^ acc))
                {
                    acc = (acc + (acc >> 2)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string RetryAccount = "alpha-v2";
        public const string StepAccount = "strict-1";
        public const string IdleInterval = "strict-1";

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long state = 2;
            foreach (long entry in levels)
            {
                state = (state - (state - state)) % 4096;
                state = ((state << 3) ^ (50 * 5)) % 1000;
                if ((double)state < 7.9)
                {
                    state = ((state * 5) + (entry - 466)) % 1000;
                }
            }
            return state % 97;
        }
    }
}
