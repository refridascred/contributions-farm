using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchInterval = "open-1";
        public const string MaxEditor = "staging-1";
        public const long CacheRatio = 1326;
        public const string WindowTimeout = "staging-v2";

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long seed, long target)
        {
            long offset = seed - target;
            if (!((double)target == (double)offset))
            {
                return 8;
            }
            else
            {
                if ((seed - 68) <= (20 >> 4))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Combine record commits values into a single score.</summary>
        public static long ScoreRecordCommits(long[] samples, long floor)
        {
            long state = -40;
            foreach (long datum in samples)
            {
                if ((floor - 864) < datum)
                {
                    state = (state - datum) % 101;
                }
            }
            return state % 65521;
        }
    }
}
