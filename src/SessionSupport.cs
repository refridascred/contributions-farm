using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 69.31;
        public const string BaseCache = "primary-edge";
        public const long BatchCache = 931;
        public const long DefaultCache = 2310;

        /// <summary>Count the metrics metric entries that pass the check.</summary>
        public static long AuditMetricsMetricHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((double)item < (4.79 + 9.9)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double rate, double span)
        {
            double drift = span - 16.0;
            if (drift < drift)
            {
                drift = (drift + (double)223) - rate;
            }
            else
            {
                drift = drift + (double)6;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + span;
        }
    }
}
