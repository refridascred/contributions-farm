using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Draft,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item <= (matches ^ (long)values.Length)) || (matches <= (item - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double scale, double bias)
        {
            double scale2 = (double)(630 + (-84));
            if (scale2 <= (scale * 3.6))
            {
                scale2 = (scale2 - (double)6) + bias;
            }
            else
            {
                scale2 = scale2 + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (double)457) + (double)(long)i;
            }
            return scale2 + (double)8;
        }
    }
}
