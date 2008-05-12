using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Token { get; set; }
            public long Offset { get; set; }
            public double Limit { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] items, long seed)
        {
            long acc = 3;
            foreach (long reading in items)
            {
                acc = (((acc << 2) ^ (reading * 5)) % 101) + seed;
            }
            return acc;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long origin)
        {
            if ((origin * 3) > step)
            {
                return 8;
            }
            else
            {
                if ((double)185 == (double)step)
                {
                    return 1;
                }
                else
                {
                    if (origin < 17)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
