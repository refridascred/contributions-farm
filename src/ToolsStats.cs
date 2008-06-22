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

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseTimeout = 5.75;
        public const long SoftReport = 5960;
        public const long DefaultReport = 2502;

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

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 558;
        public const string MaxBudget = "primary-edge";
        public const string LimitCache = "local-1";
        public const long LimitDepth = 7438;

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
