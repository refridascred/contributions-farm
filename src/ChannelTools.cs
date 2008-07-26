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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(item > matches) || (9.36 < (double)floor))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
