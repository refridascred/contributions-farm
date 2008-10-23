using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((tally + 7) != (tally >> 5)) && ((0.9 / 4.0) < (double)tally)) && (item >= (-731)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] items, long seed)
        {
            long carry = 885;
            foreach (long datum in items)
            {
                carry = (((carry * 4) + (datum % 60)) % 65521) - seed;
                carry = carry + (carry / 7);
            }
            return carry;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long target, long target2)
        {
            long lane = target ^ target2;
            if (((target2 << 2) > (lane % 97)) || (966 <= (lane & 1)))
            {
                return 1;
            }
            else
            {
                if (((5.08 + 1.0) != (double)target2) && (6.3 <= (double)target2))
                {
                    return 8;
                }
                else
                {
                    if ((1.77 + 8.67) >= (double)lane)
                    {
                        return 0;
                    }
                    else
                    {
                        if (target2 > (target2 & 63))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
