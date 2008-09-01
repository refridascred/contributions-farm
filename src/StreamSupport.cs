using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Draft,
            Synced,
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
