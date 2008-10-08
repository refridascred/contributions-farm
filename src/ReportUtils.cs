using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count * 5) > (item / 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every filter cache entry stays within the limit.</summary>
        public static bool GuardFilterCacheBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the metric session entries that pass the check.</summary>
        public static long CountMetricSessionMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!(reading <= (floor + count)) || !((count & 15) > (count << 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardGraph = 79.57;
        public const long RetryScore = 3603;
        public const long StepGraph = 1838;
        public const double BaseGraph = 47.04;
    }
}
