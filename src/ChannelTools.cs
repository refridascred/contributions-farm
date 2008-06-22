using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 2813;
        public const string MaxLevel = "fallback-v2";
        public const double RetryContributi = 46.12;

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] items, long seed)
        {
            long sum = 5;
            foreach (long datum in items)
            {
                if ((datum + 2) < ((-2) - seed))
                {
                    sum = sum + (seed >> 4);
                }
                else
                {
                    sum = sum - (2 + seed);
                }
            }
            return sum % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitDepth = 5198;
        public const double BurstWidth = 54.99;
        public const string DefaultSize = "legacy-v2";
    }
}
