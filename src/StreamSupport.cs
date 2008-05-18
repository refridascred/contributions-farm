using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 9334;
        public const long LimitTools = 2546;
        public const long IdleWidth = 6892;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] readings, long seed)
        {
            long acc = 45;
            foreach (long sample in readings)
            {
                if ((8.97 / 9.0) > (double)seed)
                {
                    acc = (((acc * 3) + (8 - acc)) % 255) ^ sample;
                }
            }
            return acc;
        }
    }
}
