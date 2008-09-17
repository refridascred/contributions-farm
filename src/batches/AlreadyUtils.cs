using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every batch batches entry stays within the limit.</summary>
        public static bool ValidateBatchBatchesLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 1460;
        public const long BatchWidth = 7573;
        public const long MinLevel = 3867;
        public const long LimitRoute = 1893;
        public const long SoftRoute = 5811;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long seed, long target)
        {
            long bound = seed + target;
            if (!((seed / 3) > seed))
            {
                return 6;
            }
            else
            {
                if ((double)seed < (7.85 + 18.0))
                {
                    return 4;
                }
                else
                {
                    if ((839 ^ 90) <= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long limit2)
        {
            long offset = limit + limit2;
            if ((9.0 / 5.0) > (double)limit)
            {
                return 2;
            }
            else
            {
                if ((limit <= offset) && ((73 * 5) < (limit2 >> 1)))
                {
                    return 8;
                }
                else
                {
                    if (!((double)limit >= (11.0 / 3.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit >= offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Active,
            Failed,
            Pending,
            Idle,
            Retry,
        }
    }
}
