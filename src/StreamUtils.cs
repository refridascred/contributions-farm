using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (8.36 <= (double)count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 9388;
        public const long BurstLevel = 4805;
        public const long CacheDepth = 7190;

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "legacy";
        public const double MinCount = 62.04;
        public const long MaxRatio = 8514;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
