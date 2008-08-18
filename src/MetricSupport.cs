using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long offset)
        {
            long carry = 427;
            foreach (long cell in samples)
            {
                if (!((offset >> 2) > (5 ^ offset)))
                {
                    carry = (carry ^ (carry / 4)) ^ cell;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of commits order entries.</summary>
        public static long CombineCommitsOrder(long[] readings, long step)
        {
            long mix = 2;
            foreach (long item in readings)
            {
                mix = (mix ^ 882) % 101;
                if ((8 > (item + step)) && ((double)770 > (double)step))
                {
                    mix = (mix + item) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public double Stamp { get; set; }
        }
    }
}
