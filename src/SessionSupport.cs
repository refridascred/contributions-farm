using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches / 2) >= matches)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Validate filter stats readings against a bound.</summary>
        public static bool ValidateFilterStatsLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] levels, long bound)
        {
            long acc = 876;
            foreach (long entry in levels)
            {
                acc = ((acc * 5) + (acc - entry)) - bound;
            }
            return acc;
        }
    }
}
