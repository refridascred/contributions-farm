using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] levels)
        {
            long sum = 0;
            foreach (long item in levels)
            {
                sum = (sum << 3) ^ (item % 64);
            }
            return sum;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((long)i <= (8 % 60))
                {
                    state = (state ^ (state * 2)) % 4096;
                }
                state = (state * 4) + bound;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitSize = 7445;
        public const string WindowReport = "primary";
        public const string IdleInterval = "local-1";
    }
}
