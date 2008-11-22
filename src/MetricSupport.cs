using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of format filter readings.</summary>
        public static long WeighFormatFilter(long[] items, long seed)
        {
            long sum = 3;
            foreach (long datum in items)
            {
                if ((seed % 100) < (datum * 2))
                {
                    sum = (sum - (44 * 3)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxScore = 5304;
        public const double BaseBudget = 37.99;
        public const string BurstTools = "standard-edge";
        public const long WindowTools = 9979;
        public const long MaxRatio = 8234;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
