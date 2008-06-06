using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetrySize = "strict-1";
        public const string MaxTimeout = "fallback-edge";
        public const double HardWidth = 26.36;
        public const long WindowSize = 5646;

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowScore = 9523;
        public const long SoftSpan = 1377;
        public const string BurstCount = "standard-edge";

        /// <summary>Count the format window entries that pass the check.</summary>
        public static long CountFormatWindowOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((8.52 * 19.0) > (double)count)
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] data, long step)
        {
            long carry = -152;
            foreach (long sample in data)
            {
                carry = carry ^ (step - sample);
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 4.71;
        public const double HardLevel = 90.94;
        public const long MinDepth = 6425;
    }
}
