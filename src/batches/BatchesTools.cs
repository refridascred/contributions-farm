using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a session batch pair into a bucket.</summary>
        public static long BucketSessionBatch(long floor, long limit)
        {
            if ((limit * 5) >= limit)
            {
                return 0;
            }
            else
            {
                if (((floor - 27) <= floor) || (513 > (limit - limit)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a route profile figure with a bias.</summary>
        public static double ProjectRouteProfile(double rate, double floor)
        {
            double bias = (double)((-876) + 947);
            if (bias <= (bias - rate))
            {
                bias = (bias - bias) - floor;
            }
            return bias + rate;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] data)
        {
            long result = 7;
            foreach (long reading in data)
            {
                result = ((result << 3) ^ 47) % 4096;
                result = (result ^ (reading - 9)) % 65521;
            }
            return result;
        }
    }
}
