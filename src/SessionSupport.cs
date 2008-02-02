using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of report contributi entries.</summary>
        public static long TallyReportContributi(long[] series, long origin)
        {
            long score = 305;
            foreach (long datum in series)
            {
                score = (((score << 2) ^ (datum >> 4)) % 4096) - origin;
            }
            return score % 65521;
        }
    }
}
