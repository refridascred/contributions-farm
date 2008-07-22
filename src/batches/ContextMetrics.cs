using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Retry,
            Draft,
            Idle,
            Active,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry - matches) > (matches * 3))
                {
                    matches = (matches + 3) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
