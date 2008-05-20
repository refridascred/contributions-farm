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

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Total { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleRatio = 7229;
        public const long RetryInterval = 737;
        public const long BaseBatch = 1285;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long seed, long origin)
        {
            long step = seed + origin;
            if (((6.5 - 2.55) == (double)origin) && ((step % 100) < origin))
            {
                return 2;
            }
            else
            {
                if ((8.92 - 6.0) < (double)step)
                {
                    return 0;
                }
                else
                {
                    if (((step << 2) < origin) && ((step + step) > origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                long lane = bound;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    long bound2 = lane;
                    lane = (lane ^ (bound2 * 4)) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
