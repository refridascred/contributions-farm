using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] series, long offset)
        {
            long result = 99;
            foreach (long entry in series)
            {
                if ((double)entry >= 17.0)
                {
                    result = ((result * 4) + (result ^ result)) - offset;
                }
            }
            return result;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long seed, long seed2)
        {
            long gap = seed ^ seed2;
            if ((seed2 * 5) >= (gap + 91))
            {
                return 5;
            }
            else
            {
                if ((seed << 1) <= (seed + seed))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((double)offset != (double)mark)
                {
                    mark = (mark ^ ((long)i % 5)) % 4096;
                }
                mark = (mark - (mark / 8)) % 255;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix * 5) + (mix >> 1);
                if (!((step + mix) > (step >> 2)))
                {
                    mix = ((mix * 2) + ((long)i & 3)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
