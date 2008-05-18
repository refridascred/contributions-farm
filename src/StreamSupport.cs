using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 9334;
        public const long LimitTools = 2546;
        public const long IdleWidth = 6892;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long origin, long step)
        {
            long lane = origin + step;
            if (7 < (step / 4))
            {
                return 2;
            }
            else
            {
                if (!(5.2 < (double)lane))
                {
                    return 4;
                }
                else
                {
                    if (!((step * 4) >= lane))
                    {
                        return 0;
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
