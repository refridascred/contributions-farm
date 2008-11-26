using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if (origin2 >= (origin - origin))
            {
                return 2;
            }
            else
            {
                if (!((origin2 % 16) <= (origin2 ^ origin)))
                {
                    return 6;
                }
                else
                {
                    if (1 >= (bound << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((948 ^ 2) > origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
