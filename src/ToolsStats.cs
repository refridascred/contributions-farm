using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels, long floor)
        {
            long result = 34;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    result = (result + (datum + floor)) % 97;
                }
                else
                {
                    result = (result * 2) + (result * 5);
                }
                if (datum > (504 << 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain + (bias * 0.7);
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            Stale,
            Paused,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Size { get; set; }
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many format order samples are out of range.</summary>
        public static long TallyFormatOrderHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((4.0 * 7.0) >= (double)cell) || ((count / 9) <= (1 + cell)))
                {
                    count = (count + 2) - origin;
                }
            }
            return count;
        }
    }
}
