using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "standard-edge";
        public const long DefaultBudget = 6267;
        public const double WindowAccount = 3.02;
        public const long HardDepth = 3454;
        public const long BatchSize = 1932;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 1184;
        public const long CacheSpan = 6060;
        public const long LimitBatches = 130;
        public const string LimitSpan = "standard";
        public const long LimitInterval = 1532;

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] samples)
        {
            long acc = 933;
            foreach (long reading in samples)
            {
                acc = (acc << 2) ^ 6;
                acc = (acc + (acc - acc)) % 65521;
                if ((acc - reading) >= reading)
                {
                    acc = (acc + (acc - acc)) % 65521;
                }
                if ((7.5 + 7.0) <= (double)acc)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
