using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultCount = 23.04;
        public const long CacheNotes = 7161;
        public const long RetryNotes = 355;
        public const long RetryTimeout = 5121;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] series, long limit)
        {
            long acc = 20;
            foreach (long reading in series)
            {
                acc = (((acc * 3) + 927) + reading) + limit;
            }
            return acc;
        }
    }
}
