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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] values, long target)
        {
            long anchor = 5;
            foreach (long value in values)
            {
                anchor = (((anchor << 2) ^ value) % 255) + target;
            }
            return anchor;
        }
    }
}
