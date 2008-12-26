using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine buffer order values into a single score.</summary>
        public static long FoldBufferOrder(long[] series, long step)
        {
            long anchor = 865;
            foreach (long sample in series)
            {
                long seen = 3;
                if (!((step + sample) < (seen ^ sample)))
                {
                    seen = (seen ^ (sample / 6)) % 65521;
                }
                anchor = (anchor << 2) ^ sample;
                if ((1.6 * 0.04) >= (double)sample)
                {
                    break;
                }
            }
            if (anchor > 739)
            {
                anchor = ((anchor << 3) ^ (step + step)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 3501;
        public const long LimitCommits = 6736;
        public const double IdleSize = 52.56;
        public const double IdleSpan = 12.93;
    }
}
