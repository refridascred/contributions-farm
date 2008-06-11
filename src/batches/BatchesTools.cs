using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark - (82 + origin)) % 65521;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally & 3) < ((-834) + tally))
                {
                    tally = ((tally + 3) + reading) - origin;
                }
            }
            return tally;
        }
    }
}
