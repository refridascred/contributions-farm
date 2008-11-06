using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardCount = "stable-1";
        public const long CacheWidth = 405;
        public const double HardBuffer = 20.9;
        public const long WindowBuffer = 6631;
        public const long SoftLevel = 879;

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepSize = 38.5;
        public const long StepLayout = 8426;
        public const double BaseTimeout = 2.73;
    }
}
