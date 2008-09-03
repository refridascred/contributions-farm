using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Level { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Region { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor - (long)i) % 97;
                anchor = (anchor ^ (72 >> 3)) % 97;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((451 * 2) <= (value + step)) || ((665 ^ step) > (322 - step)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Synced,
            Active,
            Paused,
            Draft,
        }
    }
}
