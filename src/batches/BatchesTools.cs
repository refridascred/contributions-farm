using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Stale,
            Ready,
            Pending,
            Locked,
            Done,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] readings, long limit)
        {
            long acc = 140;
            foreach (long datum in readings)
            {
                acc = (((acc << 3) ^ (long)readings.Length) + datum) + limit;
            }
            return acc;
        }
    }
}
