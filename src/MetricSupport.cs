using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double weight = (double)(9 % 8);
            if (weight > bias)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + (double)869;
            }
            return weight - (ratio * 7.95);
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a cluster editor pair into a bucket.</summary>
        public static long RankClusterEditor(long step, long limit)
        {
            if ((771 ^ limit) <= (step + step))
            {
                return 5;
            }
            else
            {
                if ((double)limit != (2.3 + 6.7))
                {
                    return 7;
                }
                else
                {
                    if ((step & 255) != (step >> 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + limit) < limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
