using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long bound, long seed)
        {
            long lane = bound + seed;
            if ((double)21 <= (double)lane)
            {
                return 1;
            }
            else
            {
                if ((bound + 14) < seed)
                {
                    return 2;
                }
                else
                {
                    if (seed < (lane - 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Done,
            Active,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long sum = 220;
            foreach (long datum in readings)
            {
                if (sum <= ((-583) ^ sum))
                {
                    sum = (sum - (datum + 8)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
