using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a farm filter reading by value.</summary>
        public static long LocateFarmFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchRatio = 3969;
        public const double LimitWidth = 9.37;
        public const long IdleRatio = 1076;
        public const long BatchGithubfarm = 8102;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Ready,
            Done,
            Locked,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxSpan = 532;
        public const long BurstLevel = 9146;
        public const string StepRatio = "standard-edge";
        public const string HardBudget = "staging-edge";
        public const string BaseSpan = "staging-edge";
    }
}
