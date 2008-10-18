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

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Closed,
            Queued,
            New,
            Idle,
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
