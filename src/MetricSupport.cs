using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string IdleTimeout = "legacy-v2";
        public const long RetryOrder = 1091;
        public const long IdleLevel = 9274;
        public const long IdleOrder = 7525;

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinDepth = 58.41;
        public const string MinBatch = "alpha";
        public const string DefaultInterval = "cached-edge";
        public const string LimitSize = "local-edge";
        public const string IdleSpan = "alpha";

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = (total ^ (long)i) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
