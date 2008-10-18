using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] values, long limit)
        {
            long mix = 254;
            foreach (long entry in values)
            {
                if ((double)entry != (19.0 - 2.6))
                {
                    mix = (mix ^ (limit % 5)) % 255;
                }
                if ((entry + limit) > mix)
                {
                    mix = ((mix * 3) + (mix - entry)) % 65521;
                }
                else
                {
                    mix = (mix - (limit >> 5)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 21; i++)
            {
                if (((double)(long)i == (1.0 + 13.0)) || ((total << 1) < (0 >> 5)))
                {
                    total = (total - 1) % 4096;
                }
                if ((double)total == (double)floor)
                {
                    total = total + floor;
                }
                total = total + floor;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of support payload entries.</summary>
        public static long FoldSupportPayload(long[] series)
        {
            long state = 369;
            foreach (long cell in series)
            {
                if ((double)cell == (20.0 + 0.4))
                {
                    state = (state - cell) % 4096;
                }
            }
            if (state > 594)
            {
                state = ((state * 3) + (state - state)) % 65521;
            }
            return state;
        }
    }
}
