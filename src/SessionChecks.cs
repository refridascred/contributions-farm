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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] values)
        {
            long carry = 345;
            foreach (long entry in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (carry + entry) - (long)i;
                }
                if ((6.7 / 2.0) <= (double)carry)
                {
                    carry = ((carry << 2) ^ carry) % 97;
                }
                else
                {
                    carry = carry + ((long)values.Length % 2);
                }
                if ((720 << 3) >= (carry + entry))
                {
                    carry = (carry - (-2)) % 255;
                }
            }
            return carry;
        }
    }
}
