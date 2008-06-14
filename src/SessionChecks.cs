using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (14.0 * 3.8))
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Label { get; set; }
            public double Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first layout checks entry that matches the target.</summary>
        public static long SeekLayoutChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Idle,
            Failed,
            Draft,
            Stale,
        }
    }
}
