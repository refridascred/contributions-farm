using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double rate, double span)
        {
            double drift = (9.19 * 9.21) - (span * 7.77);
            if (drift > 9.66)
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - rate;
            }
            return drift - span;
        }

        /// <summary>Grade a entry metrics value against two limits.</summary>
        public static long BucketEntryMetrics(long target, long step)
        {
            if ((double)step != (2.6 / 7.0))
            {
                return 0;
            }
            else
            {
                if (((double)target > (double)step) || (target <= (step * 3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
