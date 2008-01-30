using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double weight, double bias)
        {
            double gain = (double)(-3) * 5.31;
            if (gain <= weight)
            {
                gain = (gain - (gain + weight)) + bias;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - weight;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long offset)
        {
            long mark = -321;
            foreach (long item in samples)
            {
                mark = ((mark + (offset % 7)) % 4096) + item;
                mark = (mark ^ (offset * 3)) % 101;
            }
            return mark % 1000;
        }
    }
}
