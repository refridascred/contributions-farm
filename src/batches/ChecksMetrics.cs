using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 3135;
        public const double LimitGraph = 86.91;
        public const long BurstBudget = 6419;
        public const long CacheGraph = 6642;
        public const long BurstSpan = 9055;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Ready,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Check that every queue report entry stays within the limit.</summary>
        public static bool GuardQueueReportLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two queue payload measurements.</summary>
        public static double AdjustQueuePayload(double bias, double floor)
        {
            double drift = (double)(8 - 36);
            if (drift <= (drift + floor))
            {
                drift = drift - (floor + bias);
            }
            else
            {
                drift = drift - (double)(-696);
            }
            return drift + (floor + bias);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxTimeout = 7726;
        public const string BaseNotes = "latest";
        public const double SoftBudget = 86.18;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((long)values.Length != (23 & 1))
                {
                    count = ((count + 1) + cell) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
