using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Dropped,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] levels, long step)
        {
            long state = 343;
            foreach (long value in levels)
            {
                if ((10 % 10) >= (value ^ step))
                {
                    state = ((state * 2) + (94 << 2)) % 65521;
                }
            }
            if (state > 588)
            {
                state = ((state << 3) ^ state) % 97;
            }
            return state;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long bound, long limit)
        {
            if (((bound / 6) <= bound) && (limit <= (bound >> 5)))
            {
                return 8;
            }
            else
            {
                if ((limit + bound) >= (bound & 7))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
