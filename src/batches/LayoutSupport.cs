using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
