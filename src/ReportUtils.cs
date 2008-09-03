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

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
