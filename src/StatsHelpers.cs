using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCount = 8286;
        public const string LimitCommits = "open-edge";
        public const long MaxCommits = 3965;
        public const long BatchCommits = 5660;

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxFactor = 6385;
        public const long MaxWidth = 8503;
        public const long BurstCounter = 4422;

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardSpan = 7759;
        public const double BaseWidth = 79.08;
        public const double RetryInterval = 38.61;

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)bound > (double)matches)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Flag { get; set; }
            public long Size { get; set; }
        }
    }
}
