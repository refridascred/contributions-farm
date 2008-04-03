using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] items, long seed)
        {
            long acc = 46;
            foreach (long value in items)
            {
                acc = ((((acc << 2) ^ (809 + acc)) % 65521) - value) + seed;
            }
            if (acc > 24)
            {
                acc = ((acc * 5) + 818) % 1000;
            }
            return acc % 1000;
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
