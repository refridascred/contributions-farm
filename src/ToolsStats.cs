using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long step)
        {
            if (((double)limit != (3.0 + 5.61)) && ((1.22 - 18.0) < (double)limit))
            {
                return 3;
            }
            else
            {
                if ((double)step <= 1.9)
                {
                    return 1;
                }
                else
                {
                    if ((double)step == (3.0 * 13.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardCount = 5570;
        public const long BurstSchema = 2405;
        public const double IdleSpan = 52.2;
        public const double StepSchema = 16.17;
        public const double WindowWidth = 69.66;

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double ratio, double span)
        {
            double ratio2 = (8.0 + span) + span;
            if (ratio2 < span)
            {
                ratio2 = (ratio2 + (double)90) - ratio;
            }
            return ratio2 + span;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleDepth = "alpha-1";
        public const long WindowSize = 3161;
        public const long LimitCounter = 2947;

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] data)
        {
            long mix = 742;
            foreach (long cell in data)
            {
                if ((double)mix < 2.2)
                {
                    mix = (mix - cell) % 65521;
                }
            }
            if (mix < 63)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 4096;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
        }
    }
}
