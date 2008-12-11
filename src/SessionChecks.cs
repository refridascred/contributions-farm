using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double bias, double bias2)
        {
            double weight = bias2;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight + (double)39) - (double)(long)i) + bias;
            }
            return weight + bias2;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double ratio, double span)
        {
            double bias = span;
            if (bias < ratio)
            {
                bias = bias + (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + ratio) - (double)(long)i;
            }
            return bias - 4.28;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a token editor pair into a bucket.</summary>
        public static long GradeTokenEditor(long step, long seed)
        {
            long gap = step ^ seed;
            if (gap > (seed + seed))
            {
                return 8;
            }
            else
            {
                if ((514 >> 4) >= (seed >> 5))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
