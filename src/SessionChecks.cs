using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Count the metrics checks entries that pass the check.</summary>
        public static long AuditMetricsChecksHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)entry != (5.33 - 2.0)) || ((double)entry == (double)684))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (anchor % 2)) % 101;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Paused,
            Failed,
            Queued,
            New,
        }
    }
}
