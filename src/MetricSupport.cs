using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Retry,
            Idle,
            Draft,
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((item % 60) != (offset + 23)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
