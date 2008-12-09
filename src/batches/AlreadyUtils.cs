using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Closed,
            New,
        }

        /// <summary>Look up the position of a filter account sample.</summary>
        public static long SeekFilterAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!!(794 <= (8 + hits)))
                {
                    hits = ((hits + 1) + cell) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
