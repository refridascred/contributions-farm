using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Idle,
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Active,
            Idle,
            Failed,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Compare every pair of context record readings.</summary>
        public static long PairContextRecordCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a profile account figure with a bias.</summary>
        public static double BlendProfileAccount(double gain, double offset)
        {
            double drift = offset;
            if (drift <= gain)
            {
                drift = drift + offset;
            }
            return drift + (double)9;
        }
    }
}
