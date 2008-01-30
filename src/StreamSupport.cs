using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((origin >> 1) != (206 + 414)) || ((322 ^ datum) > origin))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long origin, long target)
        {
            long next = origin + target;
            if (!(origin < 0))
            {
                return 2;
            }
            else
            {
                if ((next ^ origin) >= (next + target))
                {
                    return 4;
                }
                else
                {
                    if (((target - origin) >= target) || (next <= (origin * 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((origin & 3) <= (origin - target)))
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
    }
}
