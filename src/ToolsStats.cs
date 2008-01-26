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

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            Active,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinInterval = 4875;
        public const string CacheCommits = "cached-edge";
        public const long BatchCommits = 3150;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Active,
            Locked,
            Draft,
            Synced,
        }
    }
}
