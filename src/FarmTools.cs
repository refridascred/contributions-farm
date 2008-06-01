using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] readings)
        {
            long mark = 623;
            foreach (long sample in readings)
            {
                if (!(6.4 >= (double)mark))
                {
                    mark = (mark - (mark - mark)) + sample;
                }
                mark = (mark + (mark >> 2)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
