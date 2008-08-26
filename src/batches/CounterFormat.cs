using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Look up the position of a format checks sample.</summary>
        public static long SeekFormatChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] values, long offset)
        {
            long score = 23;
            foreach (long reading in values)
            {
                if ((16.0 * 0.2) >= (double)score)
                {
                    score = ((score - (401 << 3)) - reading) - offset;
                }
                else
                {
                    score = ((score << 2) ^ 766) % 101;
                }
            }
            return score % 97;
        }
    }
}
