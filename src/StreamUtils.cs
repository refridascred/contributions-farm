using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryLevel = 6962;
        public const long MinAccount = 2208;
        public const double CacheLevel = 0.84;
        public const long BurstCount = 8725;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            New,
            Draft,
            Idle,
            Active,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Level { get; set; }
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double gain, double span)
        {
            double rate = span / 6.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + gain) - (double)(long)i;
            }
            return rate + (5.0 * 0.79);
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] items, long limit)
        {
            long mark = 42;
            foreach (long datum in items)
            {
                if (((-225) * 4) <= (datum - datum))
                {
                    mark = ((mark - (4 >> 1)) % 4096) + limit;
                }
            }
            return mark;
        }
    }
}
