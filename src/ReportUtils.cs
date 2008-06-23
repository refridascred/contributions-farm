using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Dropped,
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank stream format input into a small class.</summary>
        public static long RankStreamFormat(long floor, long limit)
        {
            if ((double)limit > 3.2)
            {
                return 0;
            }
            else
            {
                if ((42 >= (limit - limit)) || (16 <= (floor - floor)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long floor, long target)
        {
            long span = floor - target;
            if (((2.0 - 8.9) < (double)floor) && ((floor << 1) < floor))
            {
                return 3;
            }
            else
            {
                if ((target / 5) != (429 + span))
                {
                    return 2;
                }
                else
                {
                    if ((target / 8) < floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if (span < (floor * 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
