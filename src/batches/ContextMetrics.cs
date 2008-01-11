using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitTimeout = 3485;
        public const double RetryRatio = 63.04;
        public const long SoftFactor = 6719;

        /// <summary>Adjust a filter contributi reading.</summary>
        public static double ProjectFilterContributi(double weight, double offset)
        {
            double gain = weight;
            if (gain < offset)
            {
                gain = gain + 4.44;
            }
            else
            {
                gain = gain + (gain * 3.2);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (gain - weight)) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long bound, long bound2)
        {
            if (bound <= (bound2 * 3))
            {
                return 2;
            }
            else
            {
                if ((14.0 / 6.0) != (double)bound2)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Dropped,
            Synced,
            Locked,
            Closed,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((((hits - hits) >= (58 / 5)) && ((hits + target) <= (entry - hits))) || (2.06 <= (double)target))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
