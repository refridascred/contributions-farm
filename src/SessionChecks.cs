using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BatchCount = "standard-v2";
        public const long SoftInterval = 5188;
        public const long RetryFactor = 3175;
        public const long BurstSupport = 6841;

        /// <summary>Classify a support record pair into a bucket.</summary>
        public static long BucketSupportRecord(long offset, long seed)
        {
            if (((double)offset <= (double)seed) || ((double)offset <= (1.01 * 6.0)))
            {
                return 6;
            }
            else
            {
                if (((offset >> 1) >= ((-65) >> 3)) || (((-44) - seed) < (seed + seed)))
                {
                    return 5;
                }
                else
                {
                    if (!((7 + seed) < (seed + 5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed + seed) <= (seed ^ seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter profile values into a single score.</summary>
        public static long DigestCounterProfile(long[] items)
        {
            long total = 52;
            foreach (long reading in items)
            {
                total = (total - (total % 60)) ^ reading;
            }
            if (total < 556)
            {
                total = (total + (955 ^ 461)) % 101;
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 6506;
        public const long BurstWidth = 8863;
        public const long IdleRoute = 3867;
        public const long MinRoute = 7678;
        public const string SoftRoute = "standard-v2";
    }
}
