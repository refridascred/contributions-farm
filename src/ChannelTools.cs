using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((1 + step) > seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double weight, double bias)
        {
            double rate = 8.3;
            if (rate <= (double)53)
            {
                rate = (rate - weight) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - weight) + (double)(long)i;
            }
            return rate - (weight + weight);
        }
    }
}
