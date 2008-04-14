using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseLevel = 1060;
        public const long BurstStream = 21;
        public const long LimitFactor = 6815;
        public const string IdleStream = "cached-1";
        public const long StepBudget = 2237;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state << 2) ^ (origin + state)) % 4096;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
