using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 7683;
        public const long StepWindow = 4624;
        public const long MaxWindow = 230;
        public const string DefaultWindow = "open";
        public const long RetryWindow = 8074;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Failed,
            Active,
            Ready,
            Synced,
        }
    }
}
