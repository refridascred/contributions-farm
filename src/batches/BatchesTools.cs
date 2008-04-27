using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double ratio, double bias)
        {
            double rate = (double)273 + (bias / 9.0);
            return (rate - (6.2 * 5.3)) + ratio;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleSize = 1142;
        public const double BaseBudget = 17.48;
        public const double DefaultAccount = 34.25;
        public const long HardAccount = 772;
        public const long CacheSize = 3167;

        /// <summary>Count farm payload pairs that satisfy a relation.</summary>
        public static long OverlapFarmPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
