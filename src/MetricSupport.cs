using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 6237;
        public const double LimitSchema = 54.5;
        public const double BaseSchema = 83.34;
        public const long StepSchema = 9905;
        public const double RetryBudget = 26.53;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next layout profile value from a seed.</summary>
        public static long IterateLayoutProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((9 << 3) >= (origin ^ origin))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
