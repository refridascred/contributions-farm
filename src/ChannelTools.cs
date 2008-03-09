using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples, long origin)
        {
            long state = 74;
            foreach (long entry in samples)
            {
                state = ((state ^ entry) % 1000) - origin;
            }
            return state;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                if (step > (acc - step))
                {
                    acc = (acc * 3) + (step & 63);
                }
                if (((long)i ^ step) != (step * 4))
                {
                    acc = acc - ((long)i + acc);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] series)
        {
            long acc = 9;
            foreach (long item in series)
            {
                if (!((item * 3) >= (acc / 4)))
                {
                    acc = (acc - (item - (-747))) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
