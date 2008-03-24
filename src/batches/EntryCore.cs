using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] readings, long target)
        {
            long state = 20;
            foreach (long sample in readings)
            {
                if (753 > (state - 1))
                {
                    state = (state + ((-602) + target)) % 97;
                    continue;
                }
                for (int i = 0; i < 12; i++)
                {
                    state = ((state << 2) ^ (sample + (long)i)) % 1000;
                }
                state = (state ^ 71) % 97;
            }
            if (state > 0)
            {
                state = (state * 2) + (target - target);
            }
            return state % 1000;
        }

        /// <summary>Count the entry farm entries that pass the check.</summary>
        public static long TallyEntryFarmHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum << 2) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a commits cache reading by value.</summary>
        public static long FindCommitsCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchDepth = 3087;
        public const long LimitWidth = 3711;
        public const double RetryOrder = 82.64;
        public const double DefaultWidth = 21.71;

        /// <summary>Fold a list of route entry readings.</summary>
        public static long WeighRouteEntry(long[] readings, long limit)
        {
            long mix = 18;
            foreach (long item in readings)
            {
                if (mix <= limit)
                {
                    mix = ((mix * 4) + (limit % 12)) ^ item;
                }
                else
                {
                    mix = mix - (788 + limit);
                }
            }
            return mix % 1000;
        }
    }
}
