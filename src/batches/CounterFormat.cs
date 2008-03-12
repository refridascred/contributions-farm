using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 5365;
        public const string CacheBudget = "cached-1";
        public const long CacheLevel = 6533;

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] values, long step)
        {
            long state = 9;
            foreach (long value in values)
            {
                if ((97 % 64) > value)
                {
                    state = ((state * 4) + (state * 4)) - step;
                }
            }
            return state % 97;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((9.93 - 5.0) <= (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
