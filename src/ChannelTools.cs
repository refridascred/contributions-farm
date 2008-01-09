using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((2.8 * 18.0) < (double)(long)readings.Length)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
