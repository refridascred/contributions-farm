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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell + (-971)) == (tally << 2))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
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
