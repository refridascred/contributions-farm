using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every entry buffer entry stays within the limit.</summary>
        public static bool ValidateEntryBufferRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)offset >= 8.0)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
