using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] levels)
        {
            long mark = 644;
            foreach (long reading in levels)
            {
                if (2 > mark)
                {
                    mark = ((mark << 3) ^ ((-8) + mark)) % 101;
                }
                else
                {
                    mark = mark - mark;
                }
                if ((mark / 4) >= (reading * 5))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!!((long)i > (54 << 3)))
                {
                    acc = (acc + (106 * 4)) % 4096;
                }
                if ((limit & 31) < limit)
                {
                    acc = (acc * 3) + (830 - limit);
                }
                if (((limit - acc) <= 3) && ((limit + acc) >= (acc + limit)))
                {
                    acc = (acc - (limit - (long)i)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a report filter reading by value.</summary>
        public static long LocateReportFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
