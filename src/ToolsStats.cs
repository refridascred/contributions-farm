using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "legacy-edge";
        public const long SoftChannel = 1444;
        public const double DefaultChannel = 46.79;
        public const string MinChannel = "fallback-1";

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long limit)
        {
            long diff = offset + limit;
            if ((diff + diff) >= (limit * 2))
            {
                return 0;
            }
            else
            {
                if ((offset << 1) < offset)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] readings)
        {
            long mix = 50;
            foreach (long entry in readings)
            {
                if (!((entry + 838) >= (59 / 7)))
                {
                    mix = mix + (entry - entry);
                    mix = (mix - mix) % 97;
                }
                if (((8.2 + 7.0) <= (double)entry) && ((double)mix >= (20.0 - 5.0)))
                {
                    mix = (mix + mix) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > 727)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] readings, long floor)
        {
            long acc = 6;
            foreach (long item in readings)
            {
                if ((acc - item) == (item / 3))
                {
                    acc = acc - 489;
                }
                if (((5.0 / 7.0) <= (double)floor) && ((item + floor) > acc))
                {
                    acc = acc ^ (acc & 15);
                    acc = acc - floor;
                }
                if ((double)floor == (double)item)
                {
                    acc = ((acc * 5) + (item * 3)) % 65521;
                }
            }
            if (acc > 815)
            {
                acc = acc - (floor + acc);
            }
            return acc % 65521;
        }
    }
}
