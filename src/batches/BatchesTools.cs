using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long floor, long limit)
        {
            if ((limit % 5) < (floor << 1))
            {
                return 8;
            }
            else
            {
                if (((-5) ^ floor) < (limit ^ 59))
                {
                    return 0;
                }
                else
                {
                    if ((862 + 5) <= (floor << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)7 < (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Queued,
            Active,
            Dropped,
        }
    }
}
