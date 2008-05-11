using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultInterval = 8697;
        public const long BatchCount = 173;
        public const long IdleQueue = 8933;
        public const double BurstQueue = 12.85;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a already profile sample.</summary>
        public static long FindAlreadyProfileIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
