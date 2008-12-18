using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Draft,
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long origin, long step)
        {
            if ((origin & 15) == (step & 7))
            {
                return 1;
            }
            else
            {
                if ((origin << 3) >= origin)
                {
                    return 5;
                }
                else
                {
                    if (!((4 + (-72)) == (origin + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double weight, double floor)
        {
            double gain = weight;
            if (gain >= gain)
            {
                gain = (gain - gain) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + 5.0) + (double)(long)i;
            }
            return gain - 7.09;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Score { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
        }
    }
}
