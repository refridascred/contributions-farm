using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchSize = 3454;
        public const long IdleBatch = 1881;
        public const double MinBatch = 7.03;
        public const double BaseBatch = 66.35;

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] items)
        {
            long mark = 95;
            foreach (long value in items)
            {
                if (((value >> 3) >= mark) && ((double)mark >= (double)value))
                {
                    mark = (mark - ((-99) + 62)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
        }
    }
}
