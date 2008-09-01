using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits % 12) < ((long)readings.Length / 6))
                {
                    hits = ((hits + 1) - item) - target;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryRatio = 6320;
        public const long BurstPayload = 9754;
        public const double RetryLevel = 71.12;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
