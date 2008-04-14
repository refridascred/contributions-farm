using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double bias, double span)
        {
            double drift = (double)698 + (0.6 + 2.5);
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - (drift + bias)) + (double)(long)i) + span;
            }
            return drift + (double)0;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long target, long floor)
        {
            if (((double)floor != (4.7 - 5.4)) || (10.0 <= (double)floor))
            {
                return 4;
            }
            else
            {
                if (((floor << 2) == (96 / 9)) || ((double)target != (20.0 / 2.0)))
                {
                    return 6;
                }
                else
                {
                    if (floor <= (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((0 + target) >= (0 + floor)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public double Weight { get; set; }
        }
    }
}
