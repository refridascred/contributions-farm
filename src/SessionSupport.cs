using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double bias, double bias2)
        {
            double drift = bias2 * 19.0;
            if (drift < (bias * 2.1))
            {
                drift = drift + (7.0 + bias);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + bias) - (double)(long)i;
            }
            return drift + bias2;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long limit, long origin)
        {
            long step = limit + origin;
            if (((-60) + step) >= step)
            {
                return 2;
            }
            else
            {
                if ((limit & 63) >= (57 * 4))
                {
                    return 8;
                }
                else
                {
                    if (!((656 + step) != (step / 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step & 63) > (limit + limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
