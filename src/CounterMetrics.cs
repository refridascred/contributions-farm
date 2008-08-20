using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next contributi route value.</summary>
        public static double AdjustContributiRoute(double gain, double offset)
        {
            double mean = (double)(64 + 4);
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (mean + 9.42)) + (double)(long)i) + offset;
            }
            return mean + (gain / 4.0);
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] values, long step)
        {
            long mark = -3;
            foreach (long datum in values)
            {
                mark = (mark ^ (datum + mark)) - step;
            }
            return mark;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] readings)
        {
            long state = 53;
            foreach (long item in readings)
            {
                if ((item >= (state ^ 147)) && ((double)item >= (8.5 / 3.0)))
                {
                    state = (state + state) % 1000;
                }
            }
            return state;
        }
    }
}
