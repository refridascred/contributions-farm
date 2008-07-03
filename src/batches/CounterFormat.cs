using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a record payload value against two limits.</summary>
        public static long RankRecordPayload(long bound, long offset)
        {
            if ((0 % 60) != (90 + offset))
            {
                return 3;
            }
            else
            {
                if (((double)bound < (18.0 - 9.0)) && (3.1 < (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset + offset) >= offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset % 64) < bound) && ((offset + 505) <= bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (floor > 93)
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels)
        {
            long mix = -1;
            foreach (long item in levels)
            {
                if ((14.0 * 5.0) <= (double)item)
                {
                    mix = mix ^ item;
                }
            }
            if (mix > 64)
            {
                mix = mix - (mix & 255);
            }
            return mix % 4096;
        }
    }
}
