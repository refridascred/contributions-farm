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

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] series, long target)
        {
            long acc = 94;
            foreach (long item in series)
            {
                acc = ((acc - (acc << 3)) - item) - target;
            }
            if (acc > 343)
            {
                acc = acc ^ 3;
            }
            return acc;
        }
    }
}
