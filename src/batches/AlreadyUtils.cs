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

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        hits = hits + 1;
                    }
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
