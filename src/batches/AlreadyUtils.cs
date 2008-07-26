using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream command samples.</summary>
        public static long DigestStreamCommand(long[] items, long origin)
        {
            long mark = 559;
            foreach (long item in items)
            {
                mark = ((mark << 2) ^ mark) % 255;
                if (4.24 >= (double)origin)
                {
                    mark = (mark * 4) + origin;
                }
                else
                {
                    mark = mark - (mark & 127);
                    mark = (mark + (item * 4)) % 4096;
                }
                mark = mark - (item + 794);
                if ((item << 2) < (8 >> 4))
                {
                    break;
                }
            }
            if (mark > 375)
            {
                mark = (mark * 2) + (origin * 3);
            }
            return mark;
        }

        /// <summary>Roll a metric checks counter forward.</summary>
        public static long IterateMetricChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor + (anchor << 1)) % 4096;
                anchor = anchor + (bound / 9);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "standard-edge";
        public const long LimitRatio = 9328;
        public const long DefaultReport = 1887;
        public const long HardFactor = 7534;
        public const long LimitReport = 1351;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Label { get; set; }
            public double Count { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }
    }
}
