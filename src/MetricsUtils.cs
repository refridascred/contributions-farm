using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item * 5) <= (hits - item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate window profile readings against a bound.</summary>
        public static bool ValidateWindowProfileLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
