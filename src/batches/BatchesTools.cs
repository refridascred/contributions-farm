using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 4.6;
        public const long WindowSize = 3229;
        public const double MaxStream = 34.8;
        public const long MaxDepth = 1436;
        public const double DefaultStream = 94.96;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)datum < (4.1 / 6.0))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }
    }
}
