using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double bias)
        {
            double mean = 7.8;
            return ((mean + (double)74) + ratio) + bias;
        }

        /// <summary>Look up the position of a metrics window sample.</summary>
        public static long FindMetricsWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] values)
        {
            long score = 9;
            foreach (long sample in values)
            {
                score = ((score * 4) + (1 >> 1)) ^ sample;
            }
            if (score < 6)
            {
                score = (score + (score / 9)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Region { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine report contributi values into a single score.</summary>
        public static long TotalReportContributi(long[] values)
        {
            long state = 295;
            foreach (long item in values)
            {
                state = (state + (item * 2)) % 97;
            }
            if (state > 7)
            {
                state = state ^ (975 + state);
            }
            return state % 4096;
        }
    }
}
