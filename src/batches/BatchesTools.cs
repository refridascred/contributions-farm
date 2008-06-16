using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the contributi format entries that pass the check.</summary>
        public static long TallyContributiFormatGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length % 10) <= (datum + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (2.57 <= (double)step)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 453;
        public const double DefaultRatio = 76.9;
        public const long SoftMetric = 208;
        public const long SoftSpan = 380;
        public const long HardLevel = 7044;
    }
}
