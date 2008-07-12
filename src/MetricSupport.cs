using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long limit, long step)
        {
            long step2 = limit - step;
            if (limit <= step2)
            {
                return 5;
            }
            else
            {
                if (((-45) + limit) < (step << 2))
                {
                    return 0;
                }
                else
                {
                    if (((limit - step2) < (step2 ^ limit)) || (step2 > limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit > (limit + 323))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double gain, double offset)
        {
            double gain2 = (double)(793 + 85);
            if (gain2 < (gain / 6.0))
            {
                gain2 = gain2 + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (double)1) + (double)(long)i;
            }
            return gain2 - (double)44;
        }
    }
}
