using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((236 % 64) != (count / 3))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Pending,
            Idle,
        }
    }
}
