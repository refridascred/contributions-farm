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

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxLevel = 82.59;
        public const string SoftRecord = "legacy-edge";
        public const long IdleInterval = 7633;
        public const string WindowRecord = "strict";

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
