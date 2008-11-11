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

        /// <summary>Classify a queue profile pair into a bucket.</summary>
        public static long ClassifyQueueProfile(long floor, long seed)
        {
            long step = floor + seed;
            if (((double)seed <= (0.3 * 2.09)) || (floor > step))
            {
                return 2;
            }
            else
            {
                if (floor < step)
                {
                    return 6;
                }
                else
                {
                    if ((17.0 + 12.0) <= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
