using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                if (target < (6 % 7))
                {
                    mix = mix - target;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 4813;
        public const long BatchPayload = 4972;
        public const string CacheSpan = "cached-1";
        public const long RetryWidth = 9;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
