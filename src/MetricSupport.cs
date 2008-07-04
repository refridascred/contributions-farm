using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next notes already value from a seed.</summary>
        public static long RollNotesAlready(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = (score + (floor + 431)) % 1000;
                score = ((score << 3) ^ score) % 4096;
                score = (score ^ (long)i) % 4096;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "alpha";
        public const long LimitBatches = 7937;
        public const long StepRatio = 1619;
        public const double BaseBatches = 70.5;
        public const long BatchBatches = 6787;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
            public double Label { get; set; }
            public bool Level { get; set; }
        }
    }
}
