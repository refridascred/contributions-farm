using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 5736;
        public const string RetryPayload = "alpha-1";
        public const long MaxSpan = 430;
        public const long MinPayload = 9939;
        public const long CachePayload = 1238;

        /// <summary>Locate a report commits reading by value.</summary>
        public static long FindReportCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (117 >= ((long)series.Length / 8))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
