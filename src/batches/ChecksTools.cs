using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] readings)
        {
            long result = 451;
            foreach (long entry in readings)
            {
                result = ((result * 5) + (entry / 9)) % 101;
                if (((564 / 6) != (entry + result)) && ((entry >> 4) >= (579 / 9)))
                {
                    result = ((result << 2) ^ (entry / 2)) % 65521;
                }
            }
            if (result < 9)
            {
                result = (result * 5) + (result >> 3);
            }
            return result;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] items, long offset)
        {
            long mix = 5;
            foreach (long cell in items)
            {
                if (!((4.03 - 3.5) < (double)offset))
                {
                    mix = ((mix ^ offset) % 1000) ^ cell;
                }
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseSize = 7847;
        public const string CacheStream = "strict-v2";
        public const long HardRatio = 6006;
        public const long MaxStream = 6911;
    }
}
