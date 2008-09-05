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

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
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
