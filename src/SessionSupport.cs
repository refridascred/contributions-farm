using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long target, long floor)
        {
            long step = target - floor;
            if (((target - (-873)) >= (floor + floor)) && ((double)step <= 1.41))
            {
                return 2;
            }
            else
            {
                if ((step >> 4) > (step + target))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheWidth = 487;
        public const string IdleSupport = "cached";
        public const long RetryLevel = 5363;
        public const long StepSupport = 5905;
        public const long RetrySupport = 7694;

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheCount = 5072;
        public const long WindowLevel = 8045;
        public const double BatchEntry = 24.48;
        public const string MinTimeout = "cached-1";
        public const long DefaultTimeout = 4688;
    }
}
