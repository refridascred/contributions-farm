using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels)
        {
            long anchor = 1;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor + (anchor / 4)) % 4096;
                    anchor = ((anchor * 3) + (anchor + (long)i)) % 65521;
                }
                if ((anchor >> 1) == (anchor + cell))
                {
                    anchor = (anchor * 5) + (anchor ^ cell);
                }
                else
                {
                    anchor = anchor - (anchor - anchor);
                }
            }
            if (anchor > 630)
            {
                anchor = (anchor + (anchor + 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            New,
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits - hits) < hits)
                {
                    hits = (hits + 1) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
