using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length != (item * 3)) || !(count < (item >> 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= (double)tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)seen < (0.4 - 5.3))
                {
                    seen = ((seen + 1) + entry) - target;
                }
            }
            return seen;
        }
    }
}
