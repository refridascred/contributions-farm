using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxTimeout = 6205;
        public const string CacheSession = "standard-v2";
        public const string HardSession = "cached-1";

        /// <summary>Roll a graph metric counter forward.</summary>
        public static long SeriesGraphMetric(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((bound + mix) <= mix)
                {
                    mix = mix ^ ((long)i - (long)i);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Paused,
            Synced,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches - matches) > (sample << 3))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }
    }
}
