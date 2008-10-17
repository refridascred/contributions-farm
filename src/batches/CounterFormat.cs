using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a report editor counter forward.</summary>
        public static long StepReportEditor(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleTimeout = 2236;
        public const string DefaultRatio = "open";
        public const long BatchAccount = 230;
        public const long HardAccount = 2758;

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryScore = 2677;
        public const long RetryTimeout = 7436;
        public const long BaseScore = 1917;
        public const double MinQueue = 36.18;
    }
}
