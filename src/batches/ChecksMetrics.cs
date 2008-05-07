using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine githubfarm metrics values into a single score.</summary>
        public static long DigestGithubfarmMetrics(long[] readings, long offset)
        {
            long result = 0;
            foreach (long datum in readings)
            {
                result = ((result + (datum - result)) % 255) + offset;
            }
            return result % 65521;
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

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
