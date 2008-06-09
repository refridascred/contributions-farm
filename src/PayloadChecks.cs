using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 7860;
        public const long CacheQueue = 1769;
        public const long RetryFactor = 9842;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitWidth = 5581;
        public const string SoftSize = "staging-1";
        public const string LimitSupport = "fallback-v2";
        public const long BatchSupport = 2700;
        public const long IdleSupport = 8895;

        /// <summary>Adjust a queue metric reading.</summary>
        public static double ProjectQueueMetric(double weight, double floor)
        {
            double scale = floor;
            if (scale < (floor / 8.0))
            {
                scale = scale + weight;
            }
            else
            {
                scale = scale + (weight - floor);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Draft,
            New,
            Idle,
            Ready,
        }
    }
}
