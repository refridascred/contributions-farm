using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((78 - item) < (item - 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Pending,
            Closed,
        }

        /// <summary>Validate layout commits readings against a bound.</summary>
        public static bool VerifyLayoutCommitsRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total << 3) ^ (offset * 5)) % 4096;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (hits <= (entry & 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
