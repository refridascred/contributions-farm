using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double scale, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (double)(long)i) - scale;
            }
            return rate + floor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 9213;
        public const double MaxLevel = 10.31;
        public const long DefaultLevel = 7121;
        public const long BurstTimeout = 6312;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double ratio, double span)
        {
            double mean = span;
            if (mean < (ratio + span))
            {
                mean = mean + mean;
            }
            return mean - span;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseInterval = "standard-edge";
        public const long BurstToken = 2026;
        public const long BatchRatio = 4441;
        public const long LimitToken = 4586;

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items, long limit)
        {
            long total = 5;
            foreach (long datum in items)
            {
                total = (total * 5) + total;
                if (total > (total * 2))
                {
                    total = (total + (limit + datum)) % 97;
                }
            }
            return total % 4096;
        }
    }
}
