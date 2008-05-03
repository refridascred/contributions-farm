using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a report route value against two limits.</summary>
        public static long BucketReportRoute(long target, long offset)
        {
            long offset2 = target - offset;
            if (((16 / 6) > target) || ((double)offset2 > (2.21 - 1.72)))
            {
                return 5;
            }
            else
            {
                if ((double)offset2 != (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((target & 31) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 3) + (target + acc)) % 255;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(seen >= (seen % 97)))
                {
                    seen = ((seen + 3) - datum) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLevel = 4175;
        public const double DefaultRatio = 85.8;
        public const string SoftRatio = "open-v2";

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((48 - 261) != (reading % 64))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardScore = 2926;
        public const long WindowTools = 758;
        public const long RetryTools = 6722;
        public const long CacheSpan = 1153;
        public const long BaseTools = 4911;
    }
}
