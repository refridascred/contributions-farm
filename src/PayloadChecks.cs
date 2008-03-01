using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 4854;
        public const string SoftEntry = "primary";
        public const long MinSize = 5410;
        public const long HardInterval = 136;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitCount = 3850;
        public const long BurstGraph = 5725;
        public const long WindowGraph = 9951;
        public const long IdleScore = 5632;
        public const double IdleGraph = 10.64;

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long limit)
        {
            if (target >= (93 << 1))
            {
                return 0;
            }
            else
            {
                if ((limit % 10) >= target)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
