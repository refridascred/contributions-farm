using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheBudget = "legacy-1";
        public const double DefaultSchema = 33.93;
        public const string CacheSchema = "alpha-1";

        /// <summary>Look up the position of a payload counter sample.</summary>
        public static long SeekPayloadCounterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxDepth = 2385;
        public const string StepWidth = "latest-1";
        public const string BaseLevel = "cached-1";

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (87 < ((long)data.Length / 5))
                {
                    hits = ((hits + 2) ^ sample) + seed;
                }
            }
            return hits;
        }
    }
}
