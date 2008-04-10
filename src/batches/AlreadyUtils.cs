using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] series, long origin)
        {
            long anchor = 95;
            foreach (long sample in series)
            {
                if (!((double)origin == (double)anchor))
                {
                    anchor = anchor - (origin % 8);
                }
                if ((18.0 - 2.0) == (double)origin)
                {
                    anchor = (anchor - (anchor + sample)) % 97;
                }
                else
                {
                    anchor = (anchor - (origin - origin)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = (total + (limit - total)) % 4096;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Stamp { get; set; }
            public bool Count { get; set; }
            public string Size { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
