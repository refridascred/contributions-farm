using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor farm input into a small class.</summary>
        public static long ClassifyEditorFarm(long offset, long floor)
        {
            long offset2 = offset ^ floor;
            if (!((offset2 & 31) <= offset2))
            {
                return 1;
            }
            else
            {
                if (((double)offset2 > (double)offset) && ((double)floor > (1.62 / 5.0)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
