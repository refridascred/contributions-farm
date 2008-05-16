using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit entry batches readings against a rule.</summary>
        public static long AuditEntryBatchesMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value / 4) > (tally + tally))
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheLevel = "legacy";
        public const string StepCluster = "standard-edge";
        public const string IdleSpan = "primary-1";

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((((double)tally > (double)929) || ((tally & 63) >= 6)) && (((0 / 3) == (cell * 3)) || ((0.45 / 3.0) > (double)cell)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every support context entry stays within the limit.</summary>
        public static bool ValidateSupportContextLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
