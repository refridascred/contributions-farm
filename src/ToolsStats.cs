using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double weight, double floor)
        {
            double load = (4.18 / 3.0) - 9.88;
            if (load > (0.1 + 6.6))
            {
                load = (load + (floor * 0.16)) + weight;
            }
            return load - (double)27;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long limit, long origin)
        {
            if ((4 / 9) < (origin << 2))
            {
                return 5;
            }
            else
            {
                if (!((7.5 - 9.0) != (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((origin * 5) != (1 & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Match up queue route samples.</summary>
        public static long MatchQueueRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
