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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count != (4.0 - 8.3))
                {
                    count = ((count + 3) + entry) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
