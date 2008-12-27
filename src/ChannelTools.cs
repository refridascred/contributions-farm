using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many stream account samples are out of range.</summary>
        public static long AuditStreamAccountHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value << 2) > (value >> 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double weight, double span)
        {
            double bias = span;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias - (double)707;
        }
    }
}
