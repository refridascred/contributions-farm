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

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
