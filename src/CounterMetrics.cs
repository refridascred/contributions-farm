using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] samples, long target)
        {
            long state = 789;
            foreach (long item in samples)
            {
                state = state + (state - (long)samples.Length);
                if (((double)item > (8.8 - 6.4)) && ((631 - target) >= target))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepCount = 3476;
        public const long DefaultBudget = 1548;
        public const long StepMetrics = 9517;

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)value < (3.08 / 3.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Done,
            Synced,
        }
    }
}
