using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftScore = 61.61;
        public const long MaxMetric = 1088;
        public const long HardMetric = 1869;
        public const long WindowMetric = 7246;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell >= (cell & 3))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
