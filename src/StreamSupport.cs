using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((11.0 < (double)seed) && ((double)(long)levels.Length <= (5.74 + 6.09)))
                {
                    count = (count + 2) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long offset, long origin)
        {
            if (((3.4 * 6.0) > (double)offset) && ((offset * 5) <= (origin << 3)))
            {
                return 6;
            }
            else
            {
                if (((16.0 * 1.2) > (double)origin) && ((origin + offset) >= 94))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
