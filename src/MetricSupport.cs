using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "stable-edge";
        public const long LimitGithubfarm = 4249;
        public const long SoftGithubfarm = 8046;
        public const long MaxGithubfarm = 699;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((double)offset <= 10.0)
                {
                    score = (score << 3) ^ (offset & 127);
                }
                score = score - (offset + offset);
                score = (score << 2) ^ (score * 2);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
