using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "cached";
        public const long BatchSpan = 3495;
        public const string BatchFactor = "legacy-v2";
        public const long CacheRoute = 1651;
        public const long HardRoute = 9235;

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] series)
        {
            long sum = 5;
            foreach (long reading in series)
            {
                sum = (sum * 4) + (reading ^ reading);
            }
            return sum % 97;
        }
    }
}
