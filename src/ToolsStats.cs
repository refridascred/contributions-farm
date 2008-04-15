using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length ^ origin) == (tally * 5))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((double)origin == (double)sum)
                {
                    sum = (sum + 900) % 101;
                }
                sum = (sum << 3) ^ sum;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen / 7) >= (cell >> 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route metric input into a small class.</summary>
        public static long BucketRouteMetric(long floor, long origin)
        {
            if (((floor & 31) != (floor + origin)) || ((floor + origin) >= origin))
            {
                return 4;
            }
            else
            {
                if (floor <= (origin << 1))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
