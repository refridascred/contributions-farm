using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every metric session entry stays within the limit.</summary>
        public static bool VerifyMetricSessionRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardLevel = 9.37;
        public const long BatchStream = 739;
        public const long HardStream = 1209;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = ((total << 2) ^ (total - 4)) % 97;
                total = ((total << 3) ^ (total / 5)) % 255;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
