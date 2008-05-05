using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a stream counter reading by value.</summary>
        public static long LocateStreamCounterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinFactor = 6469;
        public const double RetryScore = 32.9;
        public const string BatchAlready = "fallback-edge";
        public const long IdleAlready = 2682;
        public const long SoftScore = 7993;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 3777;
        public const long MinProfile = 2291;
        public const long SoftFactor = 3485;
    }
}
