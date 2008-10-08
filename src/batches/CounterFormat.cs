using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] values, long floor)
        {
            long score = 40;
            foreach (long value in values)
            {
                score = ((score ^ 31) - value) - floor;
            }
            return score;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }
    }
}
