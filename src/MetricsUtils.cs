using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            New,
            Idle,
            Synced,
            Active,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long bound, long floor)
        {
            long gap = bound - floor;
            if ((bound % 24) != (gap + floor))
            {
                return 7;
            }
            else
            {
                if (bound >= floor)
                {
                    return 5;
                }
                else
                {
                    if ((6.29 - 8.3) == (double)gap)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Token { get; set; }
            public double Region { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate tools queue samples.</summary>
        public static long WeighToolsQueue(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((double)step <= 0.5)
                {
                    sum = ((sum << 2) ^ (step + 8)) - sample;
                }
            }
            if (sum < 106)
            {
                sum = (sum ^ step) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (floor < (datum ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
