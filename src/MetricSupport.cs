using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleSpan = 44.33;
        public const long HardCount = 6166;
        public const long BurstEditor = 914;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!!((2.68 / 6.0) < (double)seen))
                {
                    seen = ((seen + 1) - datum) - target;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] readings, long bound)
        {
            long acc = 3;
            foreach (long sample in readings)
            {
                acc = ((((acc * 4) + 540) % 4096) - sample) - bound;
            }
            return acc % 4096;
        }
    }
}
