using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftWidth = 8.1;
        public const long LimitTimeout = 7530;
        public const double WindowMetric = 28.44;
        public const long MaxDepth = 5645;
        public const double CacheSize = 55.03;

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxFactor = 3275;
        public const long BaseOrder = 1203;
        public const double MaxRatio = 26.69;
        public const long StepRatio = 2866;
        public const string BatchWidth = "staging-1";

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 10.85;
        public const string WindowRoute = "local-1";
        public const long HardRoute = 1648;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                sum = sum ^ 21;
                if ((floor & 7) != ((long)i ^ sum))
                {
                    sum = (sum * 5) + sum;
                    sum = sum + (floor % 16);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
