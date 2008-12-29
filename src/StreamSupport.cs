using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long floor, long bound)
        {
            if (floor <= (bound / 4))
            {
                return 6;
            }
            else
            {
                if ((floor >> 5) != (bound - floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor ^ floor) > (bound + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double weight, double offset)
        {
            double bias = weight;
            if (bias >= bias)
            {
                bias = (bias - (double)410) - offset;
            }
            return bias - weight;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits < (hits - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
