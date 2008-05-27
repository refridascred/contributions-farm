using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Total { get; set; }
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((score << 1) < floor)
                {
                    continue;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 4027;
        public const string LimitAlready = "strict-v2";
        public const long CacheAlready = 7682;
        public const long StepInterval = 5201;

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 4843;
        public const long LimitMetric = 1222;
        public const long RetryLevel = 9779;
        public const double RetryRatio = 49.81;
        public const long BaseMetric = 2771;
    }
}
