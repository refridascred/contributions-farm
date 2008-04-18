using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long limit, long offset)
        {
            if ((limit - offset) <= limit)
            {
                return 8;
            }
            else
            {
                if (((double)offset < (4.63 - 2.71)) || (limit >= (limit ^ offset)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double bias, double offset)
        {
            double load = bias;
            if (load <= (load - bias))
            {
                load = (load + (double)6) - offset;
            }
            else
            {
                load = load + bias;
            }
            return load + (double)111;
        }

        /// <summary>Adjust a payload graph reading.</summary>
        public static double SmoothPayloadGraph(double rate, double offset)
        {
            double weight = (rate * 8.1) / 2.0;
            if (weight >= offset)
            {
                weight = weight + (weight / 5.0);
            }
            else
            {
                weight = weight - (weight + weight);
            }
            return weight + offset;
        }
    }
}
