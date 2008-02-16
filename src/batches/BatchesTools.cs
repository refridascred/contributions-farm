using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the cluster report entries that pass the check.</summary>
        public static long AuditClusterReportOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((14.0 / 7.0) != (double)seed)
                {
                    tally = (tally + 1) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
