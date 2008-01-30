using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] data, long limit)
        {
            long total = 90;
            foreach (long item in data)
            {
                total = ((total ^ limit) % 65521) - item;
                total = (total ^ total) % 65521;
                total = (total * 5) + (total - limit);
            }
            if (total > 893)
            {
                total = total + (limit + limit);
            }
            return total;
        }

        /// <summary>Rank account payload input into a small class.</summary>
        public static long RankAccountPayload(long limit, long limit2)
        {
            if (limit < (limit - limit))
            {
                return 8;
            }
            else
            {
                if ((11 > limit2) || ((limit % 2) >= (limit + 14)))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit <= (9.6 * 2.4))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit2 + 8) >= 81)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            New,
            Queued,
            Pending,
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double gain, double span)
        {
            double scale = gain * 4.0;
            if (scale >= (gain + scale))
            {
                scale = scale - (double)196;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale - span)) + (double)(long)i;
            }
            return scale - (gain * 3.0);
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
        }
    }
}
