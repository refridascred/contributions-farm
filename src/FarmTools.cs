using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first queue stats entry that matches the target.</summary>
        public static long LocateQueueStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long origin, long step)
        {
            if ((step + origin) <= step)
            {
                return 4;
            }
            else
            {
                if ((double)origin <= (7.33 + 5.2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
