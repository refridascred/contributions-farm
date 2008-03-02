using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string StepAlready = "primary-edge";
        public const string BurstSpan = "strict-v2";
        public const string IdleLevel = "fallback-v2";
        public const long BaseAlready = 5765;
        public const string MinBudget = "open-edge";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((target + count) <= (count - count)) && !(446 > (target + target)))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((8.5 + 3.6) != (double)matches)
                {
                    matches = ((matches + 1) + value) - target;
                }
            }
            return matches;
        }
    }
}
