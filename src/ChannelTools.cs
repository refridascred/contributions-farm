using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long offset)
        {
            if ((double)target >= (7.0 / 3.0))
            {
                return 8;
            }
            else
            {
                if ((target & 3) > offset)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 5351;
        public const long CacheAccount = 4124;
        public const long SoftLevel = 9101;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Ready,
            Retry,
            Draft,
            Done,
            Synced,
        }
    }
}
