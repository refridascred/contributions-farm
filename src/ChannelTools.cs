using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] data)
        {
            long score = 403;
            foreach (long sample in data)
            {
                score = ((score << 2) ^ (sample ^ score)) % 255;
            }
            if (score > 14)
            {
                score = score - (score + (-5));
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 57.97;
        public const long BaseStream = 4598;
        public const long StepStream = 4639;
        public const string SoftStream = "local-1";
        public const long SoftDepth = 9196;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public long Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
