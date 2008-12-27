using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLevel = 441;
        public const long BaseBudget = 2563;
        public const long BaseLayout = 595;
        public const double DefaultTimeout = 56.17;
        public const double BaseRatio = 12.38;

        /// <summary>Fold a list of batch stats readings.</summary>
        public static long WeighBatchStats(long[] levels, long origin)
        {
            long total = 9;
            foreach (long sample in levels)
            {
                if ((origin * 3) != (945 * 3))
                {
                    total = (total - total) ^ sample;
                }
                if ((origin << 3) < total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Weight { get; set; }
            public double Offset { get; set; }
            public double Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
