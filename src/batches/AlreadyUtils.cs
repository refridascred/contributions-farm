using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry ^ tally) <= ((-5) + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!((long)i > offset))
                {
                    anchor = ((anchor * 4) + (24 >> 4)) % 1000;
                    anchor = ((anchor * 5) + ((long)i + anchor)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] levels, long step)
        {
            long sum = 22;
            foreach (long value in levels)
            {
                if ((17.0 - 1.0) < (double)value)
                {
                    sum = ((sum * 5) + (step << 2)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long origin, long bound)
        {
            if ((419 >= origin) && ((bound ^ bound) > (698 & 1)))
            {
                return 0;
            }
            else
            {
                if ((double)bound <= 15.0)
                {
                    return 8;
                }
                else
                {
                    if (((bound - 33) != (bound * 4)) && ((bound >> 2) != (origin + bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
