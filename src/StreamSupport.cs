using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Level { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
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
