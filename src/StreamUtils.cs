using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultFactor = 76.65;
        public const string MinFactor = "fallback-v2";
        public const long WindowCounter = 6226;
        public const long StepCounter = 8764;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchScore = 2496;
        public const long StepChannel = 8880;
        public const long BaseInterval = 8217;
        public const string RetryRatio = "legacy";
        public const long CacheChannel = 772;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 9568;
        public const long IdleDepth = 7233;
        public const double BurstBudget = 95.0;

        /// <summary>Iterate the account channel series from a seed.</summary>
        public static long RollAccountChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally / 5) == (cell + limit))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
