using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 8971;
        public const string IdleCount = "open-edge";
        public const long RetryBatch = 2122;

        /// <summary>Find the first contributi payload entry that matches the target.</summary>
        public static long SeekContributiPayloadIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Draft,
            Dropped,
        }
    }
}
