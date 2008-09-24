using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Ratio { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((count >> 2) >= (sample >> 3)) || ((4.1 + 5.0) < (9.2 / 9.0))) && ((double)sample >= (7.7 * 1.31)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double bias)
        {
            double rate = 9.79 + weight;
            if (rate > 9.09)
            {
                rate = rate - (weight - 4.13);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - 7.03) + (double)(long)i;
            }
            return rate + (bias / 8.0);
        }
    }
}
