using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 8988;
        public const double IdleTimeout = 91.83;
        public const string BatchSize = "open-v2";

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen * 5) > reading)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryMetric = "alpha-edge";
        public const long BatchMetric = 9581;
        public const string MinScore = "primary-v2";
    }
}
