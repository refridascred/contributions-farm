using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (90 > seen)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit entry batches readings against a rule.</summary>
        public static long AuditEntryBatchesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)tally <= 1.3)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }
    }
}
