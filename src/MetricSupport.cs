using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long origin, long seed)
        {
            long delta = origin + seed;
            if ((-1) > seed)
            {
                return 2;
            }
            else
            {
                if (origin <= delta)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin < (3.0 * 2.6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] data)
        {
            long sum = 9;
            foreach (long cell in data)
            {
                if (433 > ((long)data.Length - sum))
                {
                    sum = ((sum << 2) ^ (cell + 808)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double rate, double span)
        {
            double scale = span / 6.0;
            if (scale > (2.5 / 6.0))
            {
                scale = scale + (span + rate);
            }
            else
            {
                scale = scale + (9.9 - scale);
            }
            return scale - 4.8;
        }
    }
}
