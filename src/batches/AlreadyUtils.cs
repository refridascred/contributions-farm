using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Active,
            Locked,
            Done,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long target, long offset)
        {
            long diff = target + offset;
            if (offset <= (342 + target))
            {
                return 0;
            }
            else
            {
                if (((diff - target) < (offset + target)) && ((target + diff) != (offset - target)))
                {
                    return 3;
                }
                else
                {
                    if (target <= (diff - 68))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((diff / 3) > (46 / 4))
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

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item + 22) < (matches * 2))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }
    }
}
