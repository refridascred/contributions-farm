using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] levels, long seed)
        {
            long mix = 3;
            foreach (long value in levels)
            {
                mix = ((mix * 2) + (mix ^ value)) % 65521;
                if ((mix + (long)levels.Length) >= (seed + seed))
                {
                    mix = mix + (seed * 2);
                }
            }
            if (mix > 615)
            {
                mix = (mix + ((-1) % 97)) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Retry,
            Idle,
            Draft,
        }
    }
}
