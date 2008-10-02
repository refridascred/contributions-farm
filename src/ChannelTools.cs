using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally ^ tally) < target)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)datum >= (9.69 * 5.7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long target, long floor)
        {
            long cur = target ^ floor;
            if ((floor << 2) <= (722 - floor))
            {
                return 1;
            }
            else
            {
                if (((cur * 2) > (floor * 2)) || (308 < (floor + cur)))
                {
                    return 5;
                }
                else
                {
                    if (((floor & 7) < (target + cur)) && ((0.9 / 4.0) <= (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((cur ^ target) > floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
