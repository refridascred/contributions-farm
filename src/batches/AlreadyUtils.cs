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

        /// <summary>Count the report context entries that pass the check.</summary>
        public static long MeasureReportContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading / 4) > 34)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "standard-edge";
        public const long LimitRatio = 9328;
        public const long DefaultReport = 1887;
        public const long HardFactor = 7534;
        public const long LimitReport = 1351;

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 49.88;
        public const long BaseBatch = 9613;
        public const long SoftScore = 4770;
    }
}
