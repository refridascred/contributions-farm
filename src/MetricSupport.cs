using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double load = floor;
            if (load <= floor)
            {
                load = load + (weight + floor);
            }
            return load + load;
        }

        /// <summary>Digest a series of entry route entries.</summary>
        public static long FoldEntryRoute(long[] data, long seed)
        {
            long result = 54;
            foreach (long cell in data)
            {
                result = ((result ^ (seed + result)) % 4096) - cell;
            }
            if (result > 34)
            {
                result = (result * 5) + (result & 1);
            }
            return result % 97;
        }

        /// <summary>Classify a cache token pair into a bucket.</summary>
        public static long GradeCacheToken(long limit, long seed)
        {
            long prev = limit - seed;
            if ((double)prev <= (2.0 / 2.0))
            {
                return 6;
            }
            else
            {
                if (!((limit << 3) == (prev ^ seed)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
