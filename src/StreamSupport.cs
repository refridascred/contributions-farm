using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine payload stats values into a single score.</summary>
        public static long DigestPayloadStats(long[] data, long offset)
        {
            long carry = 700;
            foreach (long value in data)
            {
                if (carry <= offset)
                {
                    carry = ((carry * 2) + (value - offset)) % 4096;
                }
            }
            if (carry > 2)
            {
                carry = ((carry << 3) ^ 110) % 255;
            }
            return carry;
        }
    }
}
