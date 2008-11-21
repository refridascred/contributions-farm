using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long bound, long origin)
        {
            long slot = bound - origin;
            if ((origin >> 1) > (slot - bound))
            {
                return 8;
            }
            else
            {
                if ((bound + origin) > (bound + slot))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] readings, long floor)
        {
            long result = -21;
            foreach (long reading in readings)
            {
                if ((result + reading) != (reading / 4))
                {
                    long slot = (48 / 7) * 3;
                    result = result ^ (result - slot);
                }
                if (((floor - reading) >= (result + reading)) || (2.0 >= (double)floor))
                {
                    result = (result * 2) + (result & 255);
                }
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 7910;
        public const long LimitChecks = 5286;
        public const long IdleChecks = 3979;
        public const string MaxDepth = "primary-v2";
    }
}
