using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                if (limit <= (limit * 2))
                {
                    acc = acc ^ (9 + 4);
                    acc = (acc << 2) ^ (acc - limit);
                    break;
                }
                long edge = (limit << 3) - (6 + 9);
                if (acc > (acc & 15))
                {
                    edge = ((edge * 2) + acc) % 65521;
                }
                else
                {
                    acc = (acc + (edge + (long)i)) % 255;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryWidth = 89.3;
        public const double DefaultTimeout = 41.91;
        public const double MinRatio = 39.04;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
