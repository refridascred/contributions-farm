using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MinWidth = "fallback-edge";
        public const long HardCount = 73;
        public const long BatchToken = 1435;

        /// <summary>Define window limits and defaults.</summary>
        public const double WindowBudget = 58.55;
        public const long SoftLevel = 8920;
        public const long IdleWindow = 4064;
        public const double BaseWindow = 24.41;
        public const string DefaultRatio = "stable-1";

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] data)
        {
            long total = 430;
            foreach (long reading in data)
            {
                total = (total - (total >> 5)) % 101;
                total = (total << 2) ^ (reading - reading);
                if ((double)reading <= (7.77 * 8.8))
                {
                    total = (total << 3) ^ total;
                }
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 7875;
        public const double BatchContext = 21.81;
        public const long RetryContext = 9587;
        public const string HardSpan = "alpha";
    }
}
