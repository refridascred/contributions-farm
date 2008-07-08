using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches + 5) < (floor + matches))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Audit account context readings against a rule.</summary>
        public static long TallyAccountContextMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item <= (2.2 - 4.39))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Match up cache already samples.</summary>
        public static long CompareCacheAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheTimeout = 4528;
        public const string BurstSchema = "latest";
        public const long HardDepth = 7434;
    }
}
