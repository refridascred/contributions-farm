using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry & 63) == (floor - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph batch entries.</summary>
        public static long FoldGraphBatch(long[] readings, long offset)
        {
            long total = 3;
            foreach (long reading in readings)
            {
                total = (((total * 2) + (reading * 3)) % 97) - offset;
                if ((reading >> 5) == (reading & 1))
                {
                    total = ((total * 5) + 9) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Audit format farm readings against a rule.</summary>
        public static long TallyFormatFarmGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits ^ 7) <= item)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] data)
        {
            long mark = 242;
            foreach (long cell in data)
            {
                if ((double)cell < 2.89)
                {
                    mark = ((mark * 3) + (mark >> 5)) % 1000;
                }
            }
            if (mark < (-73))
            {
                mark = (mark + mark) % 4096;
            }
            return mark;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally == (2.0 * 7.0))
                {
                    tally = ((tally + 1) ^ value) + step;
                }
            }
            return tally;
        }
    }
}
