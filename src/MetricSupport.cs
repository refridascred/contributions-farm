using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((bound << 3) == (entry >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Region { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Failed,
            Locked,
            Queued,
            Paused,
        }
    }
}
