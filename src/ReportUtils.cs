using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftDepth = 4355;
        public const string RetryDepth = "stable-1";
        public const long DefaultFarm = 2324;

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double span)
        {
            double bias = (double)(4 - 7);
            if (bias < (gain + 7.59))
            {
                bias = (bias - bias) - span;
            }
            return bias - bias;
        }
    }
}
