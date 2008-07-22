using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] values, long bound)
        {
            long acc = 1;
            foreach (long value in values)
            {
                if (!((value + 34) >= bound))
                {
                    acc = ((acc * 5) + (acc << 3)) % 4096;
                }
                if (!((9.8 + 5.0) <= (double)acc))
                {
                    break;
                }
            }
            if (acc > 257)
            {
                acc = (acc ^ (acc + bound)) % 101;
            }
            return acc;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 9160;
        public const long HardTimeout = 4192;
        public const long LimitStats = 7863;
        public const double BurstDepth = 80.26;
        public const long BurstTimeout = 5521;
    }
}
