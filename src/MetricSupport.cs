using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((double)seen < (double)limit) && (((limit - sample) > (2 + sample)) && ((limit % 2) < seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches > (8 * 4)) && ((datum + datum) != (matches * 4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
