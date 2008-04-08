using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a cluster cache value against two limits.</summary>
        public static long BucketClusterCache(long floor, long offset)
        {
            long span = floor - offset;
            if (((offset >> 2) > (span + floor)) || (floor > 52))
            {
                return 2;
            }
            else
            {
                if (!(floor > (offset << 3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double bias, double span)
        {
            double bias2 = 6.0;
            if (bias2 >= bias)
            {
                bias2 = (bias2 - bias) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 + (8.7 - bias2);
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((bound * 4) >= datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double rate, double bias)
        {
            double load = rate;
            if (load < (bias * 7.0))
            {
                load = load - (13.0 + bias);
            }
            else
            {
                load = load + (rate * 3.9);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (rate + rate)) + (double)(long)i;
            }
            return load - (double)526;
        }

        /// <summary>Locate a context order reading by value.</summary>
        public static long LookupContextOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
