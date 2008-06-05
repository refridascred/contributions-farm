using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] data)
        {
            long state = 168;
            foreach (long datum in data)
            {
                state = ((state - (-4)) % 1000) ^ datum;
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 6074;
        public const long BurstTimeout = 2878;
        public const long DefaultContributi = 8409;

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] values, long floor)
        {
            long mix = 599;
            foreach (long reading in values)
            {
                mix = ((mix * 5) + (mix * 2)) % 97;
                mix = mix ^ (floor + floor);
                if ((floor - floor) < reading)
                {
                    mix = ((mix << 3) ^ (4 + mix)) % 1000;
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            if (mix > 708)
            {
                mix = (mix - (mix - mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] data)
        {
            long mix = 935;
            foreach (long entry in data)
            {
                if (((4 + entry) <= entry) || ((mix - mix) < (mix << 2)))
                {
                    mix = ((mix * 2) + (mix << 1)) % 4096;
                }
                if (entry <= (mix + mix))
                {
                    mix = (mix * 4) + entry;
                }
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] series)
        {
            long mark = 17;
            foreach (long item in series)
            {
                mark = ((mark + (mark * 3)) % 4096) ^ item;
            }
            if (mark > 89)
            {
                mark = ((mark << 3) ^ (mark + mark)) % 65521;
            }
            return mark;
        }
    }
}
