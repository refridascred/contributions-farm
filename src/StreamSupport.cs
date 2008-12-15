using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 5498;
        public const string RetrySupport = "latest-1";
        public const double StepSupport = 90.65;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((156 * 4) != (hits * 3))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }
    }
}
