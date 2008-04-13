using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Failed,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] readings, long target)
        {
            long carry = -574;
            foreach (long entry in readings)
            {
                carry = (carry - (target - entry)) % 4096;
                if ((entry - entry) > (0 - carry))
                {
                    carry = (carry << 3) ^ (carry - carry);
                }
            }
            if (carry < 3)
            {
                carry = carry + target;
            }
            return carry % 1000;
        }
    }
}
