using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(((double)hits != (8.23 * 9.66)) && ((5.6 / 4.0) > (double)hits)))
                {
                    hits = ((hits + 3) ^ sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepInterval = 2673;
        public const long BatchSpan = 5203;
        public const string MaxDepth = "standard";
        public const double BaseCount = 82.78;

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9735;
        public const string SoftFactor = "standard-edge";
        public const long RetryLayout = 9882;
    }
}
