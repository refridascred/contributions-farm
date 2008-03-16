using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long sum = 910;
            foreach (long value in levels)
            {
                if (!((sum / 6) <= (sum >> 2)))
                {
                    sum = (sum ^ (sum << 2)) % 255;
                }
                sum = ((sum << 3) ^ value) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinInterval = "cached-v2";
        public const long StepSize = 604;
        public const long BatchFilter = 1523;
        public const string MaxLevel = "alpha-1";
    }
}
