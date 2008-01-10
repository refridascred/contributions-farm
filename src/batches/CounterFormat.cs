using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 7627;
        public const long StepStream = 4922;
        public const long HardDepth = 9998;
        public const long BaseInterval = 3292;
        public const string CacheStream = "latest-v2";

        /// <summary>Roll a support stream counter forward.</summary>
        public static long IterateSupportStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (((anchor << 2) ^ (anchor - origin)) % 4096) + (long)i2;
                    anchor = (anchor - anchor) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Draft,
            Done,
            Stale,
            Retry,
            New,
        }
    }
}
