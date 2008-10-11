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

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account layout input into a small class.</summary>
        public static long RankAccountLayout(long origin, long step)
        {
            long bound = origin + step;
            if ((step + origin) <= (bound + origin))
            {
                return 5;
            }
            else
            {
                if ((step <= (origin - step)) || ((double)origin < (5.6 / 8.0)))
                {
                    return 3;
                }
                else
                {
                    if ((181 + bound) < (bound & 63))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
