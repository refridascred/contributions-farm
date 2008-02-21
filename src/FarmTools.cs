using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double weight, double bias)
        {
            double weight2 = bias;
            for (int i = 0; i < 9; i++)
            {
                weight2 = ((weight2 - (weight2 + weight2)) + (double)(long)i) - weight;
            }
            return weight2 + bias;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long offset, long floor)
        {
            long lane = offset + floor;
            if (!(offset > lane))
            {
                return 5;
            }
            else
            {
                if (9.0 > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (offset >= (floor / 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Draft,
            Retry,
            New,
        }
    }
}
