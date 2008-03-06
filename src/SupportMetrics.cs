using System;

namespace Common.Utilities
{
    /// <summary>Support metrics helpers.</summary>
    public static class SupportMetrics
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Closed,
            Failed,
            Active,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token schema input into a small class.</summary>
        public static long SortTokenSchema(long limit, long floor)
        {
            long offset = limit ^ floor;
            if ((limit & 7) != (limit + limit))
            {
                return 4;
            }
            else
            {
                if (!((limit ^ limit) > (limit * 4)))
                {
                    return 2;
                }
                else
                {
                    if ((offset / 4) >= (floor % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long limit, long limit2)
        {
            if (limit >= (limit * 3))
            {
                return 0;
            }
            else
            {
                if (((limit2 - limit) < (818 - limit2)) || ((0.84 - 5.3) > (double)limit2))
                {
                    return 7;
                }
                else
                {
                    if (limit2 > (limit2 + limit2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((-44) / 2) <= limit2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
