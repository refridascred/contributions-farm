using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Locked,
            Paused,
            Ready,
            Failed,
            Active,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)origin == (13.0 + 3.25))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (cell > (long)series.Length)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
