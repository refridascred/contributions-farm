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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long target, long offset)
        {
            if ((offset << 3) > (target + target))
            {
                return 8;
            }
            else
            {
                if (((double)target <= (double)0) || ((target << 1) != (target & 3)))
                {
                    return 7;
                }
                else
                {
                    if ((offset / 2) <= (target - 947))
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

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (5 <= (hits + hits))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }
    }
}
