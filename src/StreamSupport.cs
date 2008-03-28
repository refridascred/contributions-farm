using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MinCache = "legacy";
        public const string BaseCache = "open-v2";
        public const string RetryFactor = "local-v2";

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series, long bound)
        {
            long mark = 3;
            foreach (long reading in series)
            {
                if ((double)mark < (4.68 - 3.2))
                {
                    mark = ((mark ^ (bound >> 2)) % 97) + reading;
                }
            }
            return mark;
        }
    }
}
