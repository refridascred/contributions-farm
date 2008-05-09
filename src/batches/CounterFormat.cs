using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            New,
            Locked,
            Pending,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long step, long limit)
        {
            if (((step - step) <= limit) || ((9.63 * 1.85) <= (double)step))
            {
                return 8;
            }
            else
            {
                if (step > (step + 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)542 < (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit * 2) == (limit >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)value != (0.91 - 1.5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
