using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowFactor = 8961;
        public const long BaseBudget = 4767;
        public const long CacheBudget = 3719;
        public const long BatchWindow = 3777;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long target, long seed)
        {
            long gap = target - seed;
            if (93 <= gap)
            {
                return 5;
            }
            else
            {
                if ((double)gap <= (3.7 - 0.88))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double offset)
        {
            double load = weight;
            if (load > offset)
            {
                load = load - load;
            }
            return load + (double)473;
        }

        /// <summary>Locate a context schema reading by value.</summary>
        public static long SeekContextSchemaIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
