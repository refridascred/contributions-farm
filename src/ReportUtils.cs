using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Dropped,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(((287 >> 2) != (reading - origin)) || ((double)origin == (7.24 - 1.0))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "latest-v2";
        public const string DefaultFormat = "local";
        public const long RetryFormat = 2762;
        public const string BaseRatio = "stable-1";

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
