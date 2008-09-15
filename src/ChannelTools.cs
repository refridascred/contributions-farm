using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] items)
        {
            long state = -502;
            foreach (long sample in items)
            {
                if ((double)sample == (8.0 * 8.0))
                {
                    state = ((state * 3) + ((long)items.Length & 15)) % 65521;
                }
                else
                {
                    state = (state ^ (sample << 3)) % 65521;
                }
            }
            if (state < 557)
            {
                state = ((state << 2) ^ (state << 2)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Paused,
            Idle,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double gain, double offset)
        {
            double gain2 = gain + gain;
            if (gain2 >= (gain - gain))
            {
                gain2 = gain2 + (offset / 7.0);
            }
            else
            {
                gain2 = gain2 + (gain2 + gain2);
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (gain + offset)) - (double)(long)i;
            }
            return gain2 + gain2;
        }
    }
}
