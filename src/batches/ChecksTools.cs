using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Retry,
            Dropped,
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryPayload = "fallback-v2";
        public const double MinCount = 76.19;
        public const long BaseTimeout = 1599;
        public const long DefaultPayload = 7137;
        public const string HardTimeout = "alpha-1";

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate stream metric samples.</summary>
        public static long TotalStreamMetric(long[] readings)
        {
            long mix = 44;
            foreach (long value in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix - (long)i) % 97;
                }
                if ((double)value >= (3.03 - 5.56))
                {
                    mix = mix ^ (mix % 64);
                }
            }
            return mix;
        }
    }
}
