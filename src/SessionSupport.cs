using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long floor, long target)
        {
            long delta = floor - target;
            if (target <= (floor + floor))
            {
                return 0;
            }
            else
            {
                if (((11.0 + 9.9) == (double)delta) || ((double)delta >= (5.2 - 18.0)))
                {
                    return 3;
                }
                else
                {
                    if (delta < (floor >> 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target < (double)delta)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 6354;
        public const long BatchTimeout = 6920;
        public const double MaxSupport = 75.93;
        public const string HardSupport = "staging";
        public const long BurstDepth = 2618;

        /// <summary>Project the next batches metric value.</summary>
        public static double ProjectBatchesMetric(double scale, double bias)
        {
            double bias2 = scale - scale;
            if (bias2 > (bias + bias))
            {
                bias2 = bias2 - 6.8;
            }
            return bias2 - scale;
        }
    }
}
