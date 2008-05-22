using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 1790;
        public const double CacheContributi = 15.15;
        public const double SoftSize = 72.45;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Locked,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] series)
        {
            long score = 0;
            foreach (long value in series)
            {
                if (score >= ((-7) << 3))
                {
                    score = ((score * 4) + (value + value)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count & 63) == (count - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data)
        {
            long acc = 559;
            foreach (long value in data)
            {
                if (!(value >= acc))
                {
                    acc = ((acc * 4) + value) % 65521;
                }
            }
            if (acc < (-4))
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
        }
    }
}
