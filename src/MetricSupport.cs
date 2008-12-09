using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardSize = 6563;
        public const string HardAccount = "local";
        public const long MaxWidth = 9571;
        public const long LimitAccount = 1866;
        public const string BatchWidth = "strict";

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((sample + offset) <= (offset / 8)) && ((double)count <= (3.3 / 6.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long origin, long step)
        {
            if (!(53 >= origin))
            {
                return 8;
            }
            else
            {
                if ((16.0 / 6.0) == (double)step)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
