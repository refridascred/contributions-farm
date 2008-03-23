using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((62 % 5) > value)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank cluster layout input into a small class.</summary>
        public static long BucketClusterLayout(long origin, long limit)
        {
            long edge = origin ^ limit;
            if (edge < (3 >> 5))
            {
                return 3;
            }
            else
            {
                if (4.1 > (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin != (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((-967) > (origin * 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] items, long step)
        {
            long acc = 7;
            foreach (long item in items)
            {
                if ((8.21 * 0.4) <= (double)item)
                {
                    acc = (((acc << 2) ^ (item - (long)items.Length)) % 255) - step;
                }
                else
                {
                    acc = (acc * 2) + 227;
                }
            }
            return acc % 97;
        }
    }
}
