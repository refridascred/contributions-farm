using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchWidth = 6664;
        public const double BurstInterval = 44.52;
        public const string IdleRatio = "legacy-v2";
        public const double MaxAccount = 51.64;
        public const double LimitAccount = 63.4;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Roll a metric channel counter forward.</summary>
        public static long RollMetricChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
