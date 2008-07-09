using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Queued,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Measure how many metric editor samples are out of range.</summary>
        public static long AuditMetricEditorHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((5.2 / 8.0) <= (double)sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Failed,
            Draft,
            Pending,
            New,
        }
    }
}
