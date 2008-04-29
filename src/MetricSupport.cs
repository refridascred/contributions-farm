using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Draft,
            Done,
            Synced,
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many cache graph samples are out of range.</summary>
        public static long CountCacheGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!(sample > (tally + tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
