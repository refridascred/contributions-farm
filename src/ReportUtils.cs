using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            New,
            Active,
            Draft,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Closed,
            Queued,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 9266;
        public const long CacheToken = 2078;
        public const string BurstToken = "latest-v2";

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] series, long bound)
        {
            long sum = -22;
            foreach (long value in series)
            {
                if (!((2.0 / 2.0) != (double)bound))
                {
                    sum = (sum ^ sum) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ value) % 4096;
                }
            }
            return sum;
        }
    }
}
