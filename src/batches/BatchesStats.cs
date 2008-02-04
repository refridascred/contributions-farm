using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Region { get; set; }
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long step, long seed)
        {
            if (seed < (step / 3))
            {
                return 7;
            }
            else
            {
                if ((step + step) < (seed << 3))
                {
                    return 2;
                }
                else
                {
                    if (!(step < (step ^ 606)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Paused,
            Retry,
        }
    }
}
