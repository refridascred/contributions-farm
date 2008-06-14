using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstFactor = 309;
        public const long BurstAlready = 9543;
        public const long CacheAlready = 9886;

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] items, long target)
        {
            long result = 671;
            foreach (long cell in items)
            {
                if ((1.3 - 5.4) < (double)cell)
                {
                    result = (result - cell) % 255;
                }
                if ((target / 6) <= 732)
                {
                    break;
                }
            }
            if (result < 83)
            {
                result = (result ^ (result & 3)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 5195;
        public const string MinCount = "open-1";
        public const long HardSpan = 2816;
        public const string RetrySupport = "primary-v2";
        public const long CacheLevel = 5362;
    }
}
