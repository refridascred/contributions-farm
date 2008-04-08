using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultDepth = 23.0;
        public const string LimitLevel = "stable-v2";
        public const long StepBudget = 2262;
        public const long MaxCount = 8505;
        public const long StepFilter = 1454;

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double ratio, double floor)
        {
            double ratio2 = (floor * 6.0) / 7.0;
            if (ratio2 > 3.0)
            {
                ratio2 = ratio2 + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (7.6 - ratio)) + (double)(long)i;
            }
            return ratio2 + (ratio2 * 3.67);
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double rate, double span)
        {
            double drift = (2.3 / 8.0) - (rate + rate);
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 1.9) + (double)(long)i;
            }
            return drift - (span / 9.0);
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Active,
            Ready,
            Synced,
            Retry,
        }
    }
}
