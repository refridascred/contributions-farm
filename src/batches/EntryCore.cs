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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= 5.59)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
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
