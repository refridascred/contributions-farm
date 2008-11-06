using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of counter window entries.</summary>
        public static long TotalCounterWindow(long[] values)
        {
            long state = 356;
            foreach (long item in values)
            {
                state = ((state << 3) ^ item) % 1000;
                state = (state + (item % 7)) % 1000;
                if ((state + state) > (state * 2))
                {
                    state = state ^ (state + 74);
                }
            }
            if (state < (-512))
            {
                state = state - (state * 5);
            }
            return state % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstWidth = 5818;
        public const long RetryDepth = 6755;
        public const long MinTimeout = 5260;

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] series, long limit)
        {
            long state = 85;
            foreach (long entry in series)
            {
                if ((2 + state) <= entry)
                {
                    state = ((state + (entry + entry)) % 101) + limit;
                }
            }
            return state % 97;
        }
    }
}
