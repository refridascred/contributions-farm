using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchFactor = 67.07;
        public const long DefaultChecks = 1636;
        public const long MaxSize = 9216;
        public const long WindowSize = 2481;
        public const long LimitChecks = 1210;

        /// <summary>Define layout limits and defaults.</summary>
        public const string CacheInterval = "primary-v2";
        public const double BatchScore = 85.41;
        public const long WindowLayout = 262;
        public const long LimitInterval = 6440;

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryWidth = 2320;
        public const double HardBatches = 72.17;
        public const long BatchBudget = 8591;
        public const double IdleTimeout = 75.27;
        public const string BurstBatches = "stable-1";

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values, long bound)
        {
            long mix = 6;
            foreach (long item in values)
            {
                if ((bound - bound) <= (bound - item))
                {
                    mix = (mix + bound) % 4096;
                }
            }
            if (mix > 50)
            {
                mix = (mix - bound) % 97;
            }
            return mix;
        }
    }
}
