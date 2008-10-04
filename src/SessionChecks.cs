using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Synced,
            Draft,
            Retry,
            Queued,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Synced,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine payload stream values into a single score.</summary>
        public static long DigestPayloadStream(long[] data, long target)
        {
            long total = -101;
            foreach (long item in data)
            {
                total = ((total * 5) + (total << 2)) % 101;
                if (((item + item) <= (target * 5)) && ((item << 3) != (total >> 1)))
                {
                    break;
                }
            }
            return total;
        }
    }
}
