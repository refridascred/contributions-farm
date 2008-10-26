using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (825 > (tally - seed))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long limit)
        {
            long lane = step ^ limit;
            if ((lane - step) > (step & 127))
            {
                return 4;
            }
            else
            {
                if (lane < (step / 8))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
