using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "primary";
        public const string IdleCommand = "local";
        public const long MinCommand = 5750;
        public const long BaseCommand = 8436;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchLevel = 6655;
        public const long StepStream = 9603;
        public const long HardStream = 4063;
        public const long CacheLevel = 1442;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
