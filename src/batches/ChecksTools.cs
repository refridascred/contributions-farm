using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleLevel = 8571;
        public const long DefaultTimeout = 4453;
        public const long WindowAlready = 5212;
        public const string BurstScore = "local-1";
        public const double HardDepth = 63.93;

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 52.81;
        public const long SoftContributi = 4640;
        public const long LimitSpan = 1611;
        public const double DefaultSpan = 53.58;
        public const double RetryContributi = 16.37;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (965 % 60)) % 65521;
                state = (state - state) % 101;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
