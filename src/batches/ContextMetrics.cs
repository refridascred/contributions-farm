using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Draft,
            Done,
            Idle,
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchAccount = "stable";
        public const double MinScore = 75.84;
        public const double BaseTimeout = 85.74;
        public const double BurstWidth = 22.08;
        public const long LimitAccount = 3742;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum % 16) <= matches) || ((double)datum < (2.6 / 5.0)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstRatio = 4.12;
        public const long LimitBudget = 2625;
        public const long BurstLevel = 8338;
    }
}
