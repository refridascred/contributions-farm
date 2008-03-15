using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits ^ 40) < (hits ^ sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSize = 105;
        public const double RetrySupport = 59.3;
        public const double DefaultSupport = 73.29;
    }
}
