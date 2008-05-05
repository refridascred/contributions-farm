using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] levels)
        {
            long mix = 5;
            foreach (long reading in levels)
            {
                mix = (mix ^ (mix + mix)) % 97;
                if ((reading + (-21)) > (reading + 711))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long offset)
        {
            long delta = origin - offset;
            if ((72 * 3) <= delta)
            {
                return 7;
            }
            else
            {
                if ((delta % 12) < (offset << 3))
                {
                    return 4;
                }
                else
                {
                    if ((offset & 1) < offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (sample >= 7)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double weight, double span)
        {
            double bias = weight;
            if (bias > (18.0 * 18.0))
            {
                bias = bias - span;
            }
            return bias + bias;
        }
    }
}
