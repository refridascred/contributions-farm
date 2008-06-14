using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowLevel = 1306;
        public const double DefaultContext = 8.37;
        public const long MinWidth = 9622;
        public const double CacheDepth = 4.98;
        public const double StepContext = 76.67;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen - seen) < (datum - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
