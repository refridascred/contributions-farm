using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long bound, long bound2)
        {
            if (((-17) % 3) >= bound2)
            {
                return 0;
            }
            else
            {
                if (bound < bound2)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public double Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 73.26;
        public const long CacheFactor = 6000;
        public const long DefaultInterval = 1539;
    }
}
