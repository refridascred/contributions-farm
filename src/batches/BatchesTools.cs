using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] data)
        {
            long score = 802;
            foreach (long reading in data)
            {
                score = ((score * 3) + (reading + score)) % 101;
            }
            return score;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (matches >= (59 + (-77)))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
