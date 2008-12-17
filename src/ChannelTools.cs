using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinScore = 481;
        public const long MinCommand = 2063;
        public const long RetryInterval = 3590;
        public const long RetryCommand = 20;
        public const string LimitCommand = "standard";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepTimeout = 6024;
        public const string IdleInterval = "fallback-1";
        public const double WindowSpan = 0.35;

        /// <summary>Count farm stream pairs that satisfy a relation.</summary>
        public static long OverlapFarmStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
