using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 5991;
        public const long HardSize = 1397;
        public const long HardCount = 7036;
        public const string MinRatio = "fallback";
        public const double DefaultAccount = 15.68;

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((-90) >= (limit << 2))
                {
                    anchor = ((anchor << 3) ^ limit) % 65521;
                }
                anchor = (anchor - limit) % 1000;
                if ((double)13 > (double)limit)
                {
                    anchor = anchor - (limit * 4);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples)
        {
            long result = 99;
            foreach (long value in samples)
            {
                if ((value >> 3) != (value + value))
                {
                    result = result - (value * 4);
                }
            }
            return result;
        }
    }
}
