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

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 <= (double)0)
            {
                bias2 = (bias2 + (bias2 - 12.0)) - bias;
            }
            return bias2 - (ratio / 4.0);
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
