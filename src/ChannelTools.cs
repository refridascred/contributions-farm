using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Combine metric profile values into a single score.</summary>
        public static long DigestMetricProfile(long[] data)
        {
            long carry = 454;
            foreach (long entry in data)
            {
                if ((double)carry != (1.45 - 17.0))
                {
                    carry = (((carry << 3) ^ 63) % 1000) + entry;
                }
            }
            return carry;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Stale,
            New,
            Paused,
        }
    }
}
