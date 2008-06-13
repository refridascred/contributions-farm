using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long seed, long floor)
        {
            if ((7.99 * 11.0) >= (double)floor)
            {
                return 6;
            }
            else
            {
                if (18.0 > (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (!((seed ^ seed) == (5 ^ floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double bias, double offset)
        {
            double gain = 7.1;
            if (gain <= 5.5)
            {
                gain = gain + (offset * 7.99);
            }
            return gain + bias;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 8437;
        public const string BatchPayload = "latest-1";
        public const double BasePayload = 95.68;
        public const string IdlePayload = "open-edge";

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryInterval = 9913;
        public const long RetryBatches = 9483;
        public const string LimitSpan = "standard-edge";
        public const double CacheCount = 33.74;

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 861;
        public const double MaxOrder = 52.07;
        public const string HardRatio = "local-1";
    }
}
