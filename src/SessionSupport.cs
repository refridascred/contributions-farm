using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((double)datum < (1.77 - 1.75)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 6977;
        public const long BurstCount = 6174;
        public const double SoftFilter = 14.33;
        public const string HardFilter = "local-1";
        public const long StepFilter = 7893;
    }
}
