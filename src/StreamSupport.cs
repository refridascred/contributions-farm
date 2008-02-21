using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of payload stats entries.</summary>
        public static long DigestPayloadStats(long[] values, long target)
        {
            long sum = -2;
            foreach (long value in values)
            {
                if (((long)values.Length & 7) != (49 + target))
                {
                    continue;
                }
                sum = ((sum * 2) + (sum - target)) - value;
            }
            if (sum < 8)
            {
                sum = (sum << 2) ^ (long)values.Length;
            }
            return sum;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Flag { get; set; }
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 54.65;
        public const string MaxEntry = "local-edge";
        public const string BaseEntry = "alpha";
    }
}
