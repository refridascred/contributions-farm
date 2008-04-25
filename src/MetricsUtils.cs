using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long step, long floor)
        {
            if ((floor - 49) <= step)
            {
                return 7;
            }
            else
            {
                if (floor < (floor / 6))
                {
                    return 8;
                }
                else
                {
                    if ((3 + step) < (floor + 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-5) > (floor / 8)) && ((8.6 - 6.0) == (double)step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Count { get; set; }
            public double Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of metric counter readings.</summary>
        public static long CombineMetricCounter(long[] data)
        {
            long acc = 2;
            foreach (long cell in data)
            {
                if (((acc + 0) < (0 << 3)) || ((double)acc != (double)cell))
                {
                    acc = acc - cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 1574;
        public const double WindowDepth = 79.11;
        public const long IdleToken = 557;

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 <= (weight2 * 11.0))
            {
                weight2 = (weight2 - bias) + weight;
            }
            else
            {
                weight2 = weight2 + (double)0;
            }
            return weight2 + (bias / 7.0);
        }
    }
}
