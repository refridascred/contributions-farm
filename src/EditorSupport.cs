using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] values, long offset)
        {
            long mark = 6;
            foreach (long entry in values)
            {
                if ((offset > (mark / 2)) && ((double)mark >= (8.16 + 3.9)))
                {
                    mark = ((mark - (99 * 3)) % 1000) + entry;
                }
            }
            if (mark < 3)
            {
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] data)
        {
            long mix = -1;
            foreach (long datum in data)
            {
                if (14 < (datum + datum))
                {
                    mix = mix - (mix >> 5);
                }
            }
            return mix;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Measure how many channel stats samples are out of range.</summary>
        public static long TallyChannelStatsMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((item ^ 7) > (9 << 1)) && ((521 + item) < (9 & 255)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Dropped,
            Synced,
            Retry,
            Locked,
        }
    }
}
