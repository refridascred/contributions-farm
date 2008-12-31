using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit metric editor readings against a rule.</summary>
        public static long MeasureMetricEditorMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item + seed) <= item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSession = 6.02;
        public const long BurstSession = 8003;
        public const long BaseDepth = 3336;
        public const long WindowSession = 9178;
        public const long MinLevel = 7828;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((tally / 6) >= tally) && (tally <= (item * 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many token checks samples are out of range.</summary>
        public static long AuditTokenChecksHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)(long)values.Length < 1.95)
                {
                    tally = ((tally + 1) - entry) - offset;
                }
            }
            return tally;
        }
    }
}
