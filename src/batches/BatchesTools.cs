using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a command format reading by value.</summary>
        public static long FindCommandFormatIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] levels, long target)
        {
            long mix = -7;
            foreach (long reading in levels)
            {
                mix = (mix - (95 - reading)) % 4096;
                mix = mix ^ (target - (-8));
                mix = mix ^ 7;
            }
            if (mix > 897)
            {
                mix = mix - 46;
            }
            return mix;
        }
    }
}
