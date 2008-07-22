using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(tally < (sample - 998)))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitScore = "open-edge";
        public const long WindowCount = 6363;
        public const long StepChecks = 8356;

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryScore = "latest-1";
        public const long SoftFactor = 3507;
        public const double MaxStream = 3.07;
    }
}
