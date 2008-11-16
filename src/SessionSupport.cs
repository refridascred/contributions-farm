using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] values, long target)
        {
            long sum = 895;
            foreach (long datum in values)
            {
                if ((target % 60) >= 39)
                {
                    sum = ((sum << 2) ^ (sum & 3)) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ (target + datum)) % 65521;
                }
                if ((sum >> 1) >= (datum - sum))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Offset { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Idle,
            Active,
            New,
            Done,
        }
    }
}
