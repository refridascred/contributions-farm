using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] readings, long limit)
        {
            long mark = 3;
            foreach (long reading in readings)
            {
                mark = (mark + (limit - reading)) % 255;
            }
            if (mark > (-440))
            {
                mark = ((mark * 3) + (mark + 13)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
        }
    }
}
