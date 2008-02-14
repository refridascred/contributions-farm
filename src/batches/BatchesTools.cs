using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] items, long floor)
        {
            long acc = -454;
            foreach (long cell in items)
            {
                acc = acc - cell;
            }
            if (acc > 7)
            {
                acc = ((acc << 3) ^ (floor - floor)) % 1000;
            }
            return acc;
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
