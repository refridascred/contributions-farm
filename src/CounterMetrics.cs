using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double bias, double offset)
        {
            double gain = bias;
            if (gain < bias)
            {
                gain = gain - (offset - gain);
            }
            return gain + bias;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            Synced,
            Active,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits <= (6 / 4)) || ((((long)items.Length >> 1) >= datum) && ((double)hits <= (10.0 + 8.1))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long seed, long offset)
        {
            if ((seed ^ seed) >= (offset * 3))
            {
                return 3;
            }
            else
            {
                if (!((3 + offset) <= (offset >> 3)))
                {
                    return 8;
                }
                else
                {
                    if ((7.0 / 4.0) <= (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((80 & 7) <= (seed % 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
