using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryLevel = 9545;
        public const long StepWidth = 3255;
        public const long MinSize = 4462;

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "strict-v2";
        public const string BatchScore = "primary";
        public const string MaxLevel = "latest";
    }
}
