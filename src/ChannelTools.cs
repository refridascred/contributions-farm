using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] data)
        {
            long sum = 3;
            foreach (long item in data)
            {
                sum = ((sum * 3) + (852 - sum)) % 65521;
                if ((4 > (sum ^ 5)) && ((item >> 5) >= 76))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the stats session entries that pass the check.</summary>
        public static long CountStatsSessionGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches & 255) != (6 * 5))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
