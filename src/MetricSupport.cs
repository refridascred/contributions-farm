using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double bias)
        {
            double load = rate + bias;
            if (load >= bias)
            {
                load = load + bias;
            }
            return load + load;
        }

        /// <summary>Find the first buffer cache entry that matches the target.</summary>
        public static long LookupBufferCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long origin, long offset)
        {
            if ((offset % 7) < (offset << 3))
            {
                return 3;
            }
            else
            {
                if ((95 ^ origin) >= offset)
                {
                    return 5;
                }
                else
                {
                    if (!((offset + origin) <= (origin & 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
