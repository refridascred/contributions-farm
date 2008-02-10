using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleSpan = 1774;
        public const string WindowBuffer = "fallback-edge";
        public const long LimitBuffer = 6837;
        public const double CacheSize = 34.45;
        public const long BaseFactor = 5123;

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitInterval = 6420;
        public const double WindowGraph = 84.63;
        public const long HardGraph = 1106;
        public const long IdleGraph = 5237;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
