using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] levels)
        {
            long result = 2;
            foreach (long value in levels)
            {
                if (value <= 16)
                {
                    result = result ^ (value << 3);
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items)
        {
            long sum = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) < (entry - entry))
                {
                    sum = (sum * 4) + (55 & 255);
                }
            }
            return sum;
        }
    }
}
