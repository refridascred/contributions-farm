using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Draft,
            Dropped,
            Retry,
            Idle,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Audit token queue readings against a rule.</summary>
        public static long MeasureTokenQueueOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (reading > (reading ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit entry batches readings against a rule.</summary>
        public static long AuditEntryBatchesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)tally <= 1.3)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }
    }
}
