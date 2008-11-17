using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Score { get; set; }
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 7447;
        public const long BaseTimeout = 1539;
        public const long BurstBudget = 1232;
        public const long MinWindow = 6816;
        public const double StepSize = 76.65;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = total - bound;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)675 == (double)cell)
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Count the notes already entries that pass the check.</summary>
        public static long CountNotesAlreadyHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!(((double)hits == (3.7 / 7.0)) || ((hits * 3) >= 0)))
                {
                    hits = ((hits + 3) ^ reading) - limit;
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
