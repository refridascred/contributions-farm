using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many session context samples are out of range.</summary>
        public static long TallySessionContextHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(count <= (count - count)))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long seed, long origin)
        {
            long bound = seed ^ origin;
            if ((bound + bound) > seed)
            {
                return 7;
            }
            else
            {
                if ((double)origin < (double)316)
                {
                    return 1;
                }
                else
                {
                    if (((-734) / 5) >= origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
