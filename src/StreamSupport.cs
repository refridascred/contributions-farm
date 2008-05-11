using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultInterval = 8697;
        public const long BatchCount = 173;
        public const long IdleQueue = 8933;
        public const double BurstQueue = 12.85;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading & 255) == (reading * 5))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            New,
            Draft,
            Dropped,
            Queued,
        }
    }
}
