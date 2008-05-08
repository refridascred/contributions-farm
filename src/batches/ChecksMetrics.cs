using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every contributi commits entry stays within the limit.</summary>
        public static bool ValidateContributiCommitsRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Blend two batches queue measurements.</summary>
        public static double SmoothBatchesQueue(double weight, double span)
        {
            double bias = (double)(760 << 3);
            if (bias >= weight)
            {
                bias = bias - span;
            }
            return bias + (span + weight);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitSize = 9674;
        public const string CacheBudget = "staging-edge";
        public const long MinFarm = 5118;
        public const long DefaultFactor = 1304;
        public const long BaseRatio = 5983;

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultDepth = "legacy-1";
        public const string BaseFactor = "stable-v2";
        public const double BurstFarm = 28.69;
        public const long WindowFarm = 1402;
        public const long BurstCount = 6193;
    }
}
