using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 1371;
        public const string StepRecord = "stable-edge";
        public const double BurstRecord = 81.34;
        public const long MaxCount = 6474;
        public const string HardRecord = "legacy-v2";

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
