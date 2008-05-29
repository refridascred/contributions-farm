using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseFactor = 7426;
        public const long BatchCache = 4170;
        public const string IdleCache = "standard-edge";
        public const long BatchSize = 8965;
        public const string HardTimeout = "fallback";

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading / 6) <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstLevel = "legacy-1";
        public const long DefaultSession = 3294;
        public const string HardSpan = "alpha";
    }
}
