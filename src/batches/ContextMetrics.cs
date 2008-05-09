using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double ratio, double bias)
        {
            double drift = ratio / 6.0;
            if (drift > bias)
            {
                drift = drift - (double)82;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Classify a queue metric pair into a bucket.</summary>
        public static long RankQueueMetric(long target, long bound)
        {
            long span = target ^ bound;
            if ((1.44 * 1.0) == (double)span)
            {
                return 1;
            }
            else
            {
                if ((target - bound) < (bound * 2))
                {
                    return 0;
                }
                else
                {
                    if (target > span)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a order report value against two limits.</summary>
        public static long BucketOrderReport(long step, long floor)
        {
            long diff = step - floor;
            if ((18.0 - 19.0) != (double)diff)
            {
                return 4;
            }
            else
            {
                if (((diff % 3) < (floor % 60)) && ((diff * 3) >= floor))
                {
                    return 8;
                }
                else
                {
                    if (step < floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
