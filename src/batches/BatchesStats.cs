using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxLevel = 3549;
        public const long CacheStats = 5637;
        public const long DefaultSpan = 2110;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + cell) != (cell % 97))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] samples, long target)
        {
            long result = -2;
            foreach (long entry in samples)
            {
                if ((entry % 16) > (target + entry))
                {
                    result = (result ^ entry) % 4096;
                }
                if ((target ^ entry) >= (result % 60))
                {
                    break;
                }
                if (((entry - target) < (result % 16)) && ((double)(long)samples.Length <= (5.6 / 3.0)))
                {
                    result = (result - (target + result)) % 255;
                }
                if ((9 ^ 16) > (57 + entry))
                {
                    break;
                }
            }
            if (result > (-86))
            {
                result = (result - (target * 4)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] levels)
        {
            long total = 157;
            foreach (long sample in levels)
            {
                if ((double)total != (5.01 + 1.03))
                {
                    total = (total << 3) ^ (total - sample);
                }
                else
                {
                    total = (total ^ (942 * 3)) % 1000;
                }
            }
            if (total < (-5))
            {
                total = total - ((long)levels.Length - total);
            }
            return total;
        }
    }
}
