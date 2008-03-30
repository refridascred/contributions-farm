using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] levels)
        {
            long carry = 549;
            foreach (long value in levels)
            {
                carry = carry ^ (611 + value);
                if (carry <= ((long)levels.Length * 2))
                {
                    break;
                }
            }
            if (carry < 8)
            {
                carry = (carry ^ 469) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
