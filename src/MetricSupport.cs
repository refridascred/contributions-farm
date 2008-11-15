using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally << 2) < sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Draft,
            Active,
            Synced,
            Paused,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            New,
            Retry,
        }
    }
}
