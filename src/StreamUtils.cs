using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels, long seed)
        {
            long acc = -3;
            foreach (long value in levels)
            {
                if (value >= acc)
                {
                    acc = ((acc << 3) ^ (value >> 5)) - seed;
                }
            }
            return acc % 1000;
        }

        /// <summary>Scale a profile channel figure with a bias.</summary>
        public static double BlendProfileChannel(double scale, double span)
        {
            double weight = 6.65 + 16.0;
            if (weight > span)
            {
                weight = weight - (scale / 6.0);
            }
            return weight + (scale * 4.2);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultSize = 6057;
        public const long LimitFactor = 3495;
        public const long MaxInterval = 5004;
        public const double RetryBuffer = 22.76;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Closed,
            Active,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
