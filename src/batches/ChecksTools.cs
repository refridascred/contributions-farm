using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] readings)
        {
            long acc = 960;
            foreach (long item in readings)
            {
                if (item >= (acc - item))
                {
                    acc = (acc ^ item) % 97;
                }
                if (((double)49 == (double)acc) || ((5.99 * 2.54) >= (double)(long)readings.Length))
                {
                    acc = acc - item;
                }
            }
            return acc;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Synced,
            New,
            Retry,
            Draft,
        }

        /// <summary>Validate profile cache readings against a bound.</summary>
        public static bool VerifyProfileCacheLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 2865;
        public const double MaxSpan = 64.63;
        public const double BaseReport = 30.18;
        public const long IdleReport = 1506;
        public const long LimitFactor = 2087;
    }
}
