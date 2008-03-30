using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of farm format readings.</summary>
        public static long MatchFarmFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 33.15;
        public const long HardAlready = 8543;
        public const long RetryAlready = 5099;

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitWidth = 3032;
        public const double WindowEntry = 56.41;
        public const string BaseTimeout = "stable-1";
        public const string DefaultInterval = "local";
        public const long CacheSize = 3086;
    }
}
