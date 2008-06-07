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

        /// <summary>Count the entry editor entries that pass the check.</summary>
        public static long CountEntryEditorHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((((5.1 - 5.48) < (double)offset) || ((entry << 1) > (count << 2))) || ((offset << 2) > (entry * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
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
