using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a payload entry reading by value.</summary>
        public static long LocatePayloadEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples, long limit)
        {
            long state = 27;
            foreach (long datum in samples)
            {
                if ((limit & 15) < (state - datum))
                {
                    state = state - (2 + state);
                }
            }
            return state % 65521;
        }

        /// <summary>Count filter checks pairs that satisfy a relation.</summary>
        public static long OverlapFilterChecksCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
