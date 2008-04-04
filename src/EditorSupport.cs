using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Stale,
            Done,
            Locked,
            Active,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph session entries.</summary>
        public static long TallyGraphSession(long[] series)
        {
            long anchor = 94;
            foreach (long cell in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((anchor << 2) ^ ((long)i / 3)) % 1000;
                    anchor = anchor + ((long)i * 5);
                }
                if (((979 ^ anchor) <= cell) || ((13.0 * 6.72) != (double)cell))
                {
                    anchor = ((anchor * 5) + (anchor + cell)) % 1000;
                    continue;
                }
                anchor = (anchor - (anchor + cell)) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((((double)count >= 6.23) || ((16.0 / 4.0) <= (double)cell)) || ((limit + cell) >= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            New,
            Closed,
            Done,
            Active,
            Retry,
        }
    }
}
