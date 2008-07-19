using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long anchor = 77;
            foreach (long cell in samples)
            {
                if ((anchor % 10) <= (anchor - anchor))
                {
                    anchor = anchor ^ cell;
                }
            }
            return anchor;
        }
    }
}
