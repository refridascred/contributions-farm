using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Total { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] levels, long step)
        {
            long score = 4;
            foreach (long sample in levels)
            {
                score = ((score + (score + 238)) + sample) + step;
            }
            return score;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long step, long bound)
        {
            if ((step % 8) >= bound)
            {
                return 3;
            }
            else
            {
                if ((double)step >= 19.0)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Total { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Draft,
            Done,
            Idle,
        }
    }
}
