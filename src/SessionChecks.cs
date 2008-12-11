using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] series)
        {
            long mark = 147;
            foreach (long value in series)
            {
                mark = (mark * 2) + mark;
                if ((mark >> 1) <= (mark - mark))
                {
                    mark = (mark << 3) ^ (908 + value);
                }
            }
            if (mark > 34)
            {
                mark = (mark - (493 + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Active,
            Dropped,
            Queued,
        }

        /// <summary>Measure how many stream layout samples are out of range.</summary>
        public static long CountStreamLayoutOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum - (-35)) < target)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
