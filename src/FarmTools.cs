using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next session batches value.</summary>
        public static double ProjectSessionBatches(double gain, double bias)
        {
            double rate = gain;
            if (rate >= (bias * 5.9))
            {
                rate = rate + (rate * 3.28);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (3.0 / 7.0)) - (double)(long)i;
            }
            return rate - (bias * 16.0);
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long offset, long target)
        {
            long offset2 = offset - target;
            if ((offset ^ target) > offset2)
            {
                return 8;
            }
            else
            {
                if (!(offset2 >= ((-1) + offset2)))
                {
                    return 0;
                }
                else
                {
                    if ((((-37) - 12) >= offset2) && (offset >= (offset2 * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "standard";
        public const long MaxMetrics = 4531;
        public const string BaseDepth = "open";
        public const long BaseLevel = 4507;
    }
}
