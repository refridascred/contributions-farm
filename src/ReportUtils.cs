using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((86 / 8) <= bound)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Grade a support account value against two limits.</summary>
        public static long BucketSupportAccount(long offset, long seed)
        {
            if ((6 / 7) >= seed)
            {
                return 8;
            }
            else
            {
                if ((seed + seed) != (offset - offset))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values, long floor)
        {
            long mark = 77;
            foreach (long cell in values)
            {
                if (mark > (floor - (-886)))
                {
                    mark = mark ^ (floor - cell);
                }
            }
            if (mark < 724)
            {
                mark = mark - mark;
            }
            return mark % 97;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
