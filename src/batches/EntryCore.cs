using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate farm counter readings against a bound.</summary>
        public static bool VerifyFarmCounterRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) <= (cell - tally))
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

        /// <summary>Validate buffer batch readings against a bound.</summary>
        public static bool GuardBufferBatchRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a cache batches counter forward.</summary>
        public static long SeriesCacheBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = acc + (acc ^ acc);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
