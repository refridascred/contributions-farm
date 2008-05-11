using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                long tally = ((long)i + (long)i) - ((long)i / 8);
                if ((mark & 63) <= (offset << 2))
                {
                    tally = tally + (offset + mark);
                    continue;
                }
                if (((long)i - tally) == (tally / 3))
                {
                    mark = ((mark << 2) ^ offset) % 255;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long offset, long floor)
        {
            if ((64 % 100) <= (floor + offset))
            {
                return 1;
            }
            else
            {
                if ((15 - floor) >= offset)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
