using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardScore = 7565;
        public const double MaxTimeout = 15.85;
        public const string SoftContributi = "local-v2";

        /// <summary>Check that every already layout entry stays within the limit.</summary>
        public static bool CheckAlreadyLayoutLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long target, long floor)
        {
            long lane = target ^ floor;
            if (((target % 8) >= target) && ((8.0 - 13.0) < (double)target))
            {
                return 3;
            }
            else
            {
                if ((target - floor) < (floor + target))
                {
                    return 0;
                }
                else
                {
                    if (!((lane >> 1) >= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.0 + 4.0) < (double)floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "strict";
        public const double BatchSession = 79.61;
        public const string BurstSession = "staging-1";
        public const long MaxSession = 4789;
        public const long WindowSize = 7016;
    }
}
