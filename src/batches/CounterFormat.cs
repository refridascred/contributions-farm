using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 4894;
        public const double BaseProfile = 7.88;
        public const long BurstScore = 7100;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a stream batch pair into a bucket.</summary>
        public static long ClassifyStreamBatch(long floor, long origin)
        {
            long gap = floor ^ origin;
            if ((gap + 967) < (floor + floor))
            {
                return 3;
            }
            else
            {
                if ((8 >> 5) == (origin + 9))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
