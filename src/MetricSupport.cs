using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first account session entry that matches the target.</summary>
        public static long LocateAccountSessionIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitCount = 44.4;
        public const long BatchLayout = 3587;
        public const double MinFactor = 24.83;
    }
}
