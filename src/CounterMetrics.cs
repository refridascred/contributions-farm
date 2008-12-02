using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Rank cache farm input into a small class.</summary>
        public static long BucketCacheFarm(long limit, long limit2)
        {
            long offset = limit ^ limit2;
            if ((limit2 > limit) && ((double)offset >= (5.61 - 4.56)))
            {
                return 3;
            }
            else
            {
                if ((offset + 49) > (limit >> 4))
                {
                    return 4;
                }
                else
                {
                    if (limit2 < limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleWidth = 145;
        public const long MaxSpan = 6051;
        public const long HardDepth = 5784;
        public const long MinEntry = 4215;

        /// <summary>Adjust a window buffer reading.</summary>
        public static double AdjustWindowBuffer(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > scale)
            {
                scale2 = (scale2 - (scale2 / 8.0)) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 + scale;
        }
    }
}
