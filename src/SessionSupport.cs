using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long bound, long bound2)
        {
            long slot = bound + bound2;
            if ((double)bound > (0.93 - 8.9))
            {
                return 3;
            }
            else
            {
                if ((603 ^ slot) > bound2)
                {
                    return 4;
                }
                else
                {
                    if ((slot + bound2) < bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
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
