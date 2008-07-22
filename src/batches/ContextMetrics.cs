using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double rate, double offset)
        {
            double mean = (double)(41 * 5);
            if (mean > (double)2)
            {
                mean = (mean + (double)36) - rate;
            }
            return mean + (offset / 3.0);
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Done,
            Stale,
            Draft,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Retry,
            Stale,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchLevel = 914;
        public const string HardWidth = "standard-1";
        public const double CacheDepth = 29.17;
        public const long LimitScore = 708;
        public const string HardCommits = "fallback";

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long step, long floor)
        {
            if ((floor + floor) >= floor)
            {
                return 3;
            }
            else
            {
                if ((3.0 - 9.6) == (double)step)
                {
                    return 5;
                }
                else
                {
                    if (step >= (step - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
