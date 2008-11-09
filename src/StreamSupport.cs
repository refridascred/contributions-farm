using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchBudget = "alpha-edge";
        public const long BaseBatch = 3816;
        public const double CacheInterval = 18.75;
        public const long BurstCount = 390;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
