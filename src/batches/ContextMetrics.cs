using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double bias)
        {
            double ratio = bias;
            if (ratio <= (double)89)
            {
                ratio = (ratio - ratio) + scale;
            }
            else
            {
                ratio = ratio + (9.0 / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio * 3.8)) + (double)(long)i;
            }
            return ratio - (ratio * 3.1);
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((double)anchor <= (9.2 * 5.85)) || ((737 << 3) != (seed << 3)))
                {
                    anchor = (anchor - (anchor << 1)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 4) + anchor) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Rank { get; set; }
            public bool Score { get; set; }
            public bool Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a stream context value against two limits.</summary>
        public static long BucketStreamContext(long limit, long origin)
        {
            long bound = limit ^ origin;
            if ((double)bound != (double)bound)
            {
                return 3;
            }
            else
            {
                if ((double)bound >= (2.81 + 9.2))
                {
                    return 1;
                }
                else
                {
                    if (((322 - limit) <= limit) || ((limit - 6) >= (origin - 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardCount = 22.02;
        public const long BurstTools = 3954;
        public const long DefaultTools = 8036;
    }
}
