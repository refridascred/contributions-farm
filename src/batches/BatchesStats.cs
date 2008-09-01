using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long seed, long bound)
        {
            if ((seed + (-612)) > (seed - 60))
            {
                return 7;
            }
            else
            {
                if (((-8) + seed) == (bound + seed))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound < (2.52 / 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Level { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Label { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
