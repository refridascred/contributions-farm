using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count channel cache pairs that satisfy a relation.</summary>
        public static long OverlapChannelCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (datum <= (offset + 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
