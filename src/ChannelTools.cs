using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long origin, long origin2)
        {
            if (((origin / 4) > origin2) && ((origin >> 1) == (origin - origin)))
            {
                return 4;
            }
            else
            {
                if (!((3.12 * 4.48) >= (double)origin2))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin2 <= 3.39)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a farm layout sample.</summary>
        public static long LocateFarmLayoutIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
