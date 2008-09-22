using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((84 >> 2) != (entry >> 1))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Scale a checks already figure with a bias.</summary>
        public static double ProjectChecksAlready(double bias, double span)
        {
            double bias2 = span;
            if (bias2 <= (double)48)
            {
                bias2 = (bias2 - 7.0) + bias;
            }
            return bias2 - (span / 5.0);
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Stale,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowBudget = 8970;
        public const double RetryTimeout = 64.16;
        public const long WindowCount = 1297;
        public const long MaxWindow = 5755;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Stale,
            Queued,
            Failed,
            Synced,
        }
    }
}
