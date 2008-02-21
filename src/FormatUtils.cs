using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor * 5) + (anchor << 2);
                if (((long)i / 2) < anchor)
                {
                    anchor = (anchor + (anchor / 7)) % 101;
                    anchor = (anchor ^ (long)i) % 101;
                    continue;
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value - seed) > (value + value))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] samples)
        {
            long state = 35;
            foreach (long cell in samples)
            {
                state = (state + (state + cell)) % 1000;
                if ((4.6 + 5.59) == (double)state)
                {
                    state = (state ^ cell) % 97;
                }
                else
                {
                    state = ((state << 3) ^ (state ^ 92)) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
