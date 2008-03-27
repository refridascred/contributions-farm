using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Closed,
            Paused,
            Stale,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] samples, long target)
        {
            long carry = 309;
            foreach (long value in samples)
            {
                carry = ((carry * 3) + target) ^ value;
            }
            return carry;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            Failed,
            Closed,
            Synced,
        }
    }
}
