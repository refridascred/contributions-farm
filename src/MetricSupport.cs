using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Synced,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double bias, double offset)
        {
            double ratio = bias;
            if (ratio < (double)470)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (ratio - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (bias * 3.4)) + (double)(long)i;
            }
            return ratio + (ratio / 8.0);
        }
    }
}
