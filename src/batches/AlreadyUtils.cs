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

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long target, long floor)
        {
            long step = target ^ floor;
            if (0 <= (step - 20))
            {
                return 0;
            }
            else
            {
                if (((499 - step) == (target + floor)) && (8.7 >= (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor - step) != (step << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((2.0 / 8.0) < (double)step) || ((double)target < 8.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
