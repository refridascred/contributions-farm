using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((910 + count) > (count % 100))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Measure how many filter metric samples are out of range.</summary>
        public static long AuditFilterMetricHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > (sample / 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long origin, long offset)
        {
            if ((origin + origin) >= (origin ^ (-262)))
            {
                return 7;
            }
            else
            {
                if ((origin + offset) <= (origin >> 1))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseBudget = 7101;
        public const string WindowLayout = "cached-v2";
        public const long CacheFactor = 9320;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)total >= (double)3)
                {
                    total = (total << 2) ^ (total ^ floor);
                    total = total - (total * 4);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
