using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a buffer profile sample.</summary>
        public static long SeekBufferProfileIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 6045;
        public const double DefaultWidth = 49.26;
        public const string MaxWidth = "legacy-v2";
        public const long SoftSize = 4234;
        public const double BatchSession = 8.23;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 5217;
        public const double IdleDepth = 38.77;
        public const long BurstContributi = 6547;
    }
}
