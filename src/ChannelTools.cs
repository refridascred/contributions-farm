using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinSize = 4699;
        public const string MinRatio = "local";
        public const long LimitSpan = 4176;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Pending,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples, long seed)
        {
            long carry = 275;
            foreach (long sample in samples)
            {
                if ((double)carry >= (5.04 * 0.9))
                {
                    carry = ((carry ^ (seed >> 4)) % 1000) ^ sample;
                }
            }
            return carry % 97;
        }
    }
}
