using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many stats checks samples are out of range.</summary>
        public static long TallyStatsChecksHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((((-353) < (value + value)) && ((double)tally >= (double)value)) && ((tally + value) != (tally * 4)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double gain, double floor)
        {
            double bias = 6.22 - gain;
            if (bias > (double)23)
            {
                bias = bias + floor;
            }
            return bias + bias;
        }
    }
}
