using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix << 2) ^ (mix % 12);
                if ((mix + mix) > mix)
                {
                    mix = (mix * 3) + ((long)i + mix);
                    break;
                }
                mix = (mix + mix) % 1000;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)tally < (1.0 - 4.4))
                {
                    tally = ((tally + 2) + sample) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum & 3) < datum) || ((datum % 7) >= (datum + datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long floor, long seed)
        {
            if (((seed - seed) == (seed * 2)) || ((7.9 - 15.0) < (double)seed))
            {
                return 7;
            }
            else
            {
                if ((4 + seed) < 6)
                {
                    return 8;
                }
                else
                {
                    if ((3.5 - 3.68) >= (15.0 / 3.0))
                    {
                        return 1;
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
