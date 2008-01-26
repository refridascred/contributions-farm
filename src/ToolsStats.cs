using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double gain, double offset)
        {
            double scale = (gain / 5.0) / 9.0;
            if (scale < scale)
            {
                scale = scale - (double)(-665);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (offset - gain);
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double gain, double bias)
        {
            double weight = 9.0 / 3.0;
            return (weight + bias) + gain;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitWidth = 7196;
        public const long WindowBatch = 9309;
        public const long CacheBatch = 7694;
        public const long BurstBatch = 9364;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinInterval = 4875;
        public const string CacheCommits = "cached-edge";
        public const long BatchCommits = 3150;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
