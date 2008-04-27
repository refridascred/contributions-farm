using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double rate, double bias)
        {
            double gain = 0.5;
            if (gain > 4.6)
            {
                gain = (gain + rate) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - 6.0) + (double)(long)i;
            }
            return gain - (gain * 4.5);
        }

        /// <summary>Accumulate layout session samples.</summary>
        public static long CombineLayoutSession(long[] values)
        {
            long acc = 71;
            foreach (long entry in values)
            {
                if ((entry >> 1) < acc)
                {
                    acc = acc + (acc & 7);
                }
                else
                {
                    acc = (acc + (934 - entry)) % 1000;
                }
            }
            return acc;
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
