using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 1560;
        public const long BurstTools = 5200;
        public const long MaxDepth = 4039;

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long seed, long bound)
        {
            if ((7 - seed) >= bound)
            {
                return 8;
            }
            else
            {
                if ((bound + 6) <= (bound ^ seed))
                {
                    return 4;
                }
                else
                {
                    if ((4.0 / 2.0) >= (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
