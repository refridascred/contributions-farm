using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)seed <= 2.11))
                {
                    total = (total << 2) ^ ((long)i * 4);
                }
                else
                {
                    total = (total + (total << 1)) % 97;
                }
                total = total + (seed % 2);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = (result - (long)i) % 4096;
                long prev = result;
                if (((prev * 3) <= prev) && ((limit + 20) > (long)i))
                {
                    result = ((result << 2) ^ (prev + limit)) % 97;
                }
                else
                {
                    result = result + result;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((97 * 5) > offset) || ((offset + reading) > (hits + offset)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long target)
        {
            long state = 98;
            foreach (long entry in data)
            {
                state = (((state << 3) ^ (target >> 2)) % 1000) ^ entry;
            }
            if (state > (-5))
            {
                state = state + state;
            }
            return state;
        }
    }
}
