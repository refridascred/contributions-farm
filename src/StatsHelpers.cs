using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit checks profile readings against a rule.</summary>
        public static long AuditChecksProfileGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally * 5) == (entry ^ entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double scale, double floor)
        {
            double ratio = floor * 7.0;
            if (ratio <= floor)
            {
                ratio = ratio + (ratio + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio - (ratio + 0.55);
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            Ready,
            Draft,
            Idle,
            Pending,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "local";
        public const double HardBudget = 32.68;
        public const long DefaultCount = 8785;
    }
}
