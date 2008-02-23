using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double scale = (double)(9 & 127);
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale - scale) + (double)(long)i) - span;
            }
            return scale - (11.0 + ratio);
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] series, long limit)
        {
            long carry = 6;
            foreach (long datum in series)
            {
                if (!((carry * 4) <= (686 % 100)))
                {
                    carry = (carry ^ (7 + limit)) % 4096;
                }
                else
                {
                    carry = (carry + (limit - datum)) % 1000;
                }
            }
            if (carry > (-1))
            {
                carry = ((carry << 2) ^ carry) % 1000;
            }
            return carry;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
