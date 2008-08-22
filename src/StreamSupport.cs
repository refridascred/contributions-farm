using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Active,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 7810;
        public const long RetryProfile = 6876;
        public const long BaseCount = 2791;
        public const string HardSpan = "legacy-v2";

        /// <summary>Classify a counter profile pair into a bucket.</summary>
        public static long BucketCounterProfile(long target, long offset)
        {
            if (38 > target)
            {
                return 4;
            }
            else
            {
                if (((double)offset > 3.08) || ((16.0 - 4.9) < (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
