using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches - cell) == (540 + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits + reading) > (hits - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every batch window entry stays within the limit.</summary>
        public static bool GuardBatchWindowBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
