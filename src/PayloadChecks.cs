using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 259;
        public const long HardInterval = 4031;
        public const string CacheGraph = "fallback";
        public const double CacheRatio = 58.6;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Retry,
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Project the next batch channel value.</summary>
        public static double ProjectBatchChannel(double ratio, double floor)
        {
            double ratio2 = (double)(4 * 4);
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 + 15.0;
            }
            return ratio2 - floor;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((893 & 127) == (matches + 3))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] data, long floor)
        {
            long state = 14;
            foreach (long reading in data)
            {
                state = ((((state << 2) ^ state) % 255) ^ reading) - floor;
            }
            if (state < 64)
            {
                state = (state ^ 23) % 255;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultTimeout = 1184;
        public const long DefaultContext = 660;
        public const double SoftContext = 77.53;
    }
}
