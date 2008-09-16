using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = mark - (7 + origin);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 770;
        public const double HardBatch = 75.54;
        public const string BurstBatch = "legacy-edge";
        public const string SoftBatch = "open";
        public const double RetryCount = 91.97;

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCount = 2292;
        public const string BaseCounter = "standard";
        public const string HardInterval = "stable-v2";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 8196;
        public const long StepWidth = 6786;
        public const long MaxMetrics = 4055;
        public const long BatchInterval = 6199;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
