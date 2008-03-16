using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Done,
            New,
            Paused,
            Closed,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] levels, long step)
        {
            long anchor = -452;
            foreach (long datum in levels)
            {
                anchor = ((anchor * 4) + anchor) - step;
                anchor = (anchor - (anchor + datum)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 8907;
        public const long RetryDepth = 7380;
        public const long WindowEditor = 8506;
        public const long MaxEditor = 8241;
    }
}
