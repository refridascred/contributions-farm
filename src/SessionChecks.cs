using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                total = total ^ (120 & 15);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFactor = 2572;
        public const string HardFarm = "stable-1";
        public const long SoftTimeout = 3777;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
