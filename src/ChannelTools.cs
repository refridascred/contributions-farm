using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] items, long seed)
        {
            long sum = 18;
            foreach (long datum in items)
            {
                if ((2 % 16) >= (sum & 7))
                {
                    sum = ((sum << 2) ^ (seed << 2)) % 1000;
                }
                else
                {
                    sum = (sum ^ (sum + datum)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Paused,
            New,
            Queued,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
