using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long floor, long bound)
        {
            if (3 > floor)
            {
                return 0;
            }
            else
            {
                if (((floor / 2) <= floor) && (bound > (floor + bound)))
                {
                    return 8;
                }
                else
                {
                    if (((bound + bound) < (floor - floor)) || ((double)floor != (double)7))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((floor * 5) >= (bound + floor)) && ((floor - 28) < (floor - floor)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally - tally) == (origin - tally))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command counter entries.</summary>
        public static long TallyCommandCounter(long[] series, long seed)
        {
            long mix = 3;
            foreach (long datum in series)
            {
                if ((20.0 * 20.0) > (double)datum)
                {
                    mix = (mix << 2) ^ (mix + seed);
                }
            }
            return mix % 97;
        }
    }
}
