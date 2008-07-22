using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long floor, long limit)
        {
            long offset = floor + limit;
            if ((double)limit < (1.3 / 9.0))
            {
                return 7;
            }
            else
            {
                if ((4.9 / 8.0) > (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Done,
            Stale,
            Draft,
        }

        /// <summary>Scale a channel already figure with a bias.</summary>
        public static double ScaleChannelAlready(double ratio, double floor)
        {
            double weight = 1.8;
            if (weight >= (weight * 3.3))
            {
                weight = weight - (ratio - 9.72);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (floor * 14.0)) - (double)(long)i;
            }
            return weight + floor;
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
