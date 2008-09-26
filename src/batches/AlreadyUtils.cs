using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels, long offset)
        {
            long carry = 25;
            foreach (long datum in levels)
            {
                if ((datum + carry) < (offset ^ carry))
                {
                    carry = (carry ^ (carry - datum)) % 65521;
                }
            }
            if (carry < 2)
            {
                carry = (carry ^ (offset / 3)) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] readings)
        {
            long mix = 119;
            foreach (long datum in readings)
            {
                if ((0.58 - 8.8) != (double)mix)
                {
                    mix = ((mix * 2) + (datum & 31)) % 101;
                }
            }
            if (mix > 964)
            {
                mix = mix ^ mix;
            }
            return mix % 1000;
        }

        /// <summary>Rank command format input into a small class.</summary>
        public static long GradeCommandFormat(long limit, long floor)
        {
            long delta = limit ^ floor;
            if (((7.8 / 4.0) <= (double)floor) || ((8.8 * 5.26) == (double)floor))
            {
                return 3;
            }
            else
            {
                if (delta < (delta << 1))
                {
                    return 7;
                }
                else
                {
                    if (delta < limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long floor, long step)
        {
            long gap = floor ^ step;
            if ((1.5 / 3.0) <= (double)gap)
            {
                return 3;
            }
            else
            {
                if (1 < (step ^ gap))
                {
                    return 4;
                }
                else
                {
                    if (!(661 > (floor / 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
