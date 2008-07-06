using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSpan = 4031;
        public const long DefaultSchema = 8715;
        public const long StepSchema = 6758;
        public const long HardFactor = 4819;
        public const long HardBudget = 2094;

        /// <summary>Iterate the batch checks series from a seed.</summary>
        public static long DeriveBatchChecks(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = total ^ seed;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
