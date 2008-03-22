using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultCount = "cached-1";
        public const double IdleFactor = 30.95;
        public const double MinInterval = 14.57;
        public const string WindowCount = "staging-v2";
        public const long WindowChecks = 2883;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
