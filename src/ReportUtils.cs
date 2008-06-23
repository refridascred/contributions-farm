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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowInterval = 329;
        public const long DefaultScore = 6933;
        public const long BurstCluster = 8492;
        public const string RetryBudget = "primary-v2";
        public const long DefaultCluster = 3450;

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
