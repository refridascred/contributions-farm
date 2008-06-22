using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples)
        {
            long sum = 111;
            foreach (long item in samples)
            {
                if ((double)sum >= (4.12 * 11.0))
                {
                    sum = (sum + (item >> 4)) % 101;
                }
            }
            if (sum > 260)
            {
                sum = (sum + sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchWidth = "latest";
        public const long BurstSize = 9210;
        public const string RetryScore = "stable-1";
        public const long DefaultInterval = 6985;
        public const long BatchToken = 7149;

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepFactor = 0.86;
        public const long SoftLayout = 8533;
        public const long StepLayout = 9248;
        public const long IdleLayout = 1053;
        public const string BaseLevel = "standard";

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
