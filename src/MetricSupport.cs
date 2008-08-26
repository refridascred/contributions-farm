using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 8283;
        public const double BurstScore = 89.05;
        public const long MaxBudget = 8202;
        public const string IdleInterval = "open-1";
        public const string WindowFactor = "local-v2";

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long offset, long floor)
        {
            if ((2 >= (floor * 3)) && ((offset % 2) <= 13))
            {
                return 7;
            }
            else
            {
                if ((floor ^ floor) <= (3 - offset))
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) >= (3 << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((18.0 - 3.0) < (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
