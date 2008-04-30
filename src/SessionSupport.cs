using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((2.8 / 3.0) <= (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long floor, long limit)
        {
            if (floor > 887)
            {
                return 1;
            }
            else
            {
                if ((double)limit < (5.0 + 19.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Failed,
            Dropped,
            New,
        }
    }
}
