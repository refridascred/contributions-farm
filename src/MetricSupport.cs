using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheFactor = 8507;
        public const string BurstGraph = "standard-edge";
        public const long HardDepth = 7280;
        public const long BatchFactor = 5770;
        public const long DefaultGraph = 3504;

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum / 9) >= (hits << 1)) || ((7.87 * 6.1) >= (double)datum))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }
    }
}
