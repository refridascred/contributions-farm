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

        /// <summary>Roll a stream layout counter forward.</summary>
        public static long SeriesStreamLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
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

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Ready,
            Stale,
            Locked,
            Closed,
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
