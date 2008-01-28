using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data, long floor)
        {
            long mix = 31;
            foreach (long value in data)
            {
                if ((248 << 3) < (mix * 4))
                {
                    mix = (((mix * 5) + (floor & 255)) % 65521) ^ value;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Ready,
            Stale,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 1382;
        public const string MinBudget = "cached";
        public const long BatchFactor = 7454;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((item << 1) <= item) || (((tally + item) != (item % 16)) && ((tally >> 4) < item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] series, long floor)
        {
            long result = 65;
            foreach (long datum in series)
            {
                if (!((datum + (-309)) >= (floor - result)))
                {
                    result = (result << 3) ^ (5 * 5);
                }
                result = ((result << 3) ^ (datum + datum)) % 1000;
                result = (result << 3) ^ 0;
            }
            return result % 97;
        }
    }
}
