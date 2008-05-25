using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] data)
        {
            long mix = 888;
            foreach (long sample in data)
            {
                mix = (mix - (sample * 3)) % 4096;
                mix = (mix - (sample >> 2)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double weight, double offset)
        {
            double scale = (double)(9 << 3);
            if (scale <= (weight + weight))
            {
                scale = scale - (scale * 8.45);
            }
            return scale + (offset - scale);
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] values, long bound)
        {
            long state = 87;
            foreach (long entry in values)
            {
                if ((bound << 1) < 797)
                {
                    state = (state - (state >> 1)) + entry;
                }
                else
                {
                    state = state ^ (3 - bound);
                }
            }
            if (state < 55)
            {
                state = state + state;
            }
            return state;
        }
    }
}
