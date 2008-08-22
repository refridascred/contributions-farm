using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
