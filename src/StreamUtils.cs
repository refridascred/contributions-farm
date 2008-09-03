using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheFactor = 8.96;
        public const string LimitLevel = "cached-v2";
        public const long BurstSize = 4051;
        public const string BaseFactor = "legacy-edge";

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Done,
            Queued,
            Stale,
            New,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 95.87;
        public const long BatchBatches = 2022;
        public const long WindowDepth = 8250;
        public const long StepScore = 844;

        /// <summary>Blend two contributi githubfarm measurements.</summary>
        public static double ScaleContributiGithubfarm(double weight, double floor)
        {
            double ratio = (double)7 - 7.0;
            if (ratio < weight)
            {
                ratio = (ratio + (weight + ratio)) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (weight + ratio);
        }

        /// <summary>Classify a route account pair into a bucket.</summary>
        public static long BucketRouteAccount(long offset, long offset2)
        {
            if ((offset - 8) < (52 ^ 4))
            {
                return 2;
            }
            else
            {
                if ((offset << 3) <= offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset2 - offset2) <= (99 & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "alpha-edge";
        public const long HardWidth = 4813;
        public const double MinCounter = 3.97;
    }
}
