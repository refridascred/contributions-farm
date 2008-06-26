using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                if (!(((step - (long)i) == (long)i) && ((step - mark) < 6)))
                {
                    mark = (mark * 2) + step;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 8854;
        public const double IdleLayout = 56.52;
        public const long LimitFactor = 6163;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Size { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Count { get; set; }
            public double Total { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 2919;
        public const double BatchSpan = 83.98;
        public const long MaxLevel = 3628;
    }
}
