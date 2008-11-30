using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double bias, double span)
        {
            double rate = span;
            if (rate < bias)
            {
                rate = rate + 9.16;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (2.44 - span)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series, long bound)
        {
            long total = -702;
            foreach (long datum in series)
            {
                total = (total ^ (474 + datum)) + bound;
                if ((double)total >= (6.79 * 5.8))
                {
                    total = total - datum;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits <= sample)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
