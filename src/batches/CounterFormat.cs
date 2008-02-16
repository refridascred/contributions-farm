using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxSpan = "cached-v2";
        public const string BurstCommits = "strict-edge";
        public const long DefaultRatio = 9400;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            New,
            Idle,
            Done,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long limit, long origin)
        {
            if ((origin ^ limit) <= limit)
            {
                return 4;
            }
            else
            {
                if (!((double)limit > (7.0 / 6.0)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
