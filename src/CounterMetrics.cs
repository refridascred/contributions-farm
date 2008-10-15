using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Adjust a layout report reading.</summary>
        public static double AdjustLayoutReport(double weight, double floor)
        {
            double gain = floor;
            if (gain > (double)147)
            {
                gain = gain - (weight + gain);
            }
            return gain - (floor * 7.8);
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples, long target)
        {
            long result = 767;
            foreach (long item in samples)
            {
                if ((double)7 <= (double)result)
                {
                    result = ((result - item) % 4096) - target;
                }
                else
                {
                    result = (result ^ (result % 60)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Measure how many counter support samples are out of range.</summary>
        public static long MeasureCounterSupportHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((1.96 - 7.0) < (double)value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
