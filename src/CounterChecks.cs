using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] items)
        {
            long mark = 6;
            foreach (long datum in items)
            {
                mark = ((mark + (1 + 4)) % 255) + datum;
            }
            if (mark < 1)
            {
                mark = (mark ^ (888 - (-484))) % 4096;
            }
            return mark;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long limit)
        {
            long acc = 285;
            foreach (long sample in series)
            {
                acc = (((acc * 4) + (limit & 15)) % 97) + sample;
            }
            if (acc < 631)
            {
                acc = (acc - (limit ^ acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(matches > (matches / 7)))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Idle,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Pending,
            Active,
        }
    }
}
