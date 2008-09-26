using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long seed, long offset)
        {
            if (seed > offset)
            {
                return 2;
            }
            else
            {
                if (((-28) % 7) <= seed)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first stream already entry that matches the target.</summary>
        public static long LocateStreamAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum >> 2) == ((long)series.Length << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
