using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 6064;
        public const long CacheFactor = 6460;
        public const string IdleWidth = "stable";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
