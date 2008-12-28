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

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items)
        {
            long acc = 90;
            foreach (long datum in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc ^ (acc - datum)) % 97) - (long)i;
                }
                if (!((8.2 - 15.0) != (double)acc))
                {
                    acc = acc - (583 ^ datum);
                }
                if ((1.48 / 5.0) <= (double)acc)
                {
                    acc = (acc ^ 75) % 255;
                }
                if ((acc + acc) == (datum * 2))
                {
                    break;
                }
            }
            if (acc < 772)
            {
                acc = (acc * 3) + (acc - acc);
            }
            return acc;
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
