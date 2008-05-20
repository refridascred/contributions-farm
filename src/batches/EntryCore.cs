using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((((floor + cell) >= (seen & 7)) && ((seen - cell) == (cell << 1))) || !((90 << 3) <= (cell << 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long seed, long offset)
        {
            long gap = seed - offset;
            if ((double)gap >= (double)offset)
            {
                return 5;
            }
            else
            {
                if (seed < (offset * 3))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Pending,
            Locked,
            New,
            Paused,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                if (!((long)i >= (sum + (long)i)))
                {
                    sum = sum + sum;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
