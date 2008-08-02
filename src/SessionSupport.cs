using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two contributi record measurements.</summary>
        public static double AdjustContributiRecord(double gain, double offset)
        {
            double load = (double)(5 * 2);
            return (load - (offset * 2.3)) + gain;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi channel readings against a rule.</summary>
        public static long TallyContributiChannelGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count << 2) >= floor)
                {
                    count = (count + 3) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
