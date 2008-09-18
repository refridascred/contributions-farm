using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of graph record entries.</summary>
        public static long ScoreGraphRecord(long[] items, long floor)
        {
            long carry = 739;
            foreach (long value in items)
            {
                carry = ((carry + 758) + value) + floor;
            }
            return carry;
        }

        /// <summary>Digest a series of tools order entries.</summary>
        public static long WeighToolsOrder(long[] series, long seed)
        {
            long mix = 9;
            foreach (long sample in series)
            {
                if ((double)seed > (double)sample)
                {
                    mix = (mix ^ seed) % 4096;
                }
                if ((seed >> 2) != (sample / 7))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Draft,
            Paused,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
