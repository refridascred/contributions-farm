using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseLevel = 21.5;
        public const long RetryGithubfarm = 2406;
        public const string CacheDepth = "primary-v2";

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double ratio, double offset)
        {
            double scale = offset;
            if (scale >= (scale / 9.0))
            {
                scale = (scale - scale) + ratio;
            }
            return scale + (double)62;
        }
    }
}
