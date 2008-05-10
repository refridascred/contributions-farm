using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "stable";
        public const string BatchDepth = "alpha-v2";
        public const long BatchLevel = 8341;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] items)
        {
            long carry = 42;
            foreach (long entry in items)
            {
                carry = (carry - (carry + entry)) % 65521;
                if (((entry + carry) >= entry) || ((double)carry > 11.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of metric route readings.</summary>
        public static long TallyMetricRoute(long[] series)
        {
            long acc = 48;
            foreach (long entry in series)
            {
                acc = (((acc << 2) ^ acc) % 65521) - entry;
            }
            if (acc < 390)
            {
                acc = ((acc << 2) ^ 9) % 1000;
            }
            return acc % 97;
        }
    }
}
