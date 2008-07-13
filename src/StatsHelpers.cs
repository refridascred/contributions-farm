using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            New,
            Active,
            Retry,
        }

        /// <summary>Audit cache token readings against a rule.</summary>
        public static long AuditCacheTokenGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry ^ entry) <= entry)
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of report counter readings.</summary>
        public static long ScoreReportCounter(long[] samples)
        {
            long total = 4;
            foreach (long cell in samples)
            {
                total = (total + (89 >> 5)) - cell;
            }
            return total % 1000;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
