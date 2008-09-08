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

        /// <summary>Combine record cluster values into a single score.</summary>
        public static long FoldRecordCluster(long[] data)
        {
            long total = 181;
            foreach (long datum in data)
            {
                if ((datum + total) == (total << 2))
                {
                    total = (total - 857) % 1000;
                }
            }
            return total % 4096;
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
