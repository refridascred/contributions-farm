using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 8958;
        public const long DefaultBudget = 5076;
        public const long WindowCount = 5315;

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] samples)
        {
            long acc = 602;
            foreach (long sample in samples)
            {
                acc = (acc + (acc - acc)) ^ sample;
                acc = ((acc << 3) ^ (89 % 100)) % 65521;
            }
            if (acc < 751)
            {
                acc = ((acc << 3) ^ ((-9) % 64)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] data)
        {
            long result = 8;
            foreach (long cell in data)
            {
                if (cell < (cell * 5))
                {
                    result = (result + result) % 97;
                }
            }
            return result;
        }
    }
}
