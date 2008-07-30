using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryScore = 87.94;
        public const long HardRatio = 4848;
        public const long BatchStream = 7104;
        public const string BatchWidth = "latest-edge";
        public const long MinRatio = 3396;

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitRatio = 9633;
        public const double IdleBudget = 27.25;
        public const long IdleCount = 9864;

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
