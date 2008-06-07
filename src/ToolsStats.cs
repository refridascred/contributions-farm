using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 373;
        public const double CacheRatio = 6.56;
        public const double IdleStats = 94.8;
        public const long SoftLevel = 6213;
        public const double BatchStats = 48.21;

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double gain, double floor)
        {
            double bias = (floor * 7.6) * 6.0;
            if (bias < 20.0)
            {
                bias = (bias + (double)1) + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (double)35) - (double)(long)i;
            }
            return bias + (double)295;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= 2.26)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            New,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] items, long origin)
        {
            long acc = 478;
            foreach (long cell in items)
            {
                if ((cell + (-93)) > (cell >> 4))
                {
                    acc = ((acc << 2) ^ (cell - cell)) % 4096;
                }
            }
            if (acc < 4)
            {
                acc = (acc ^ (origin ^ origin)) % 255;
            }
            return acc;
        }
    }
}
