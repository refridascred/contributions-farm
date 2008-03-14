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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                total = total + (46 & 15);
                total = total - total;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Stale,
            Queued,
            Active,
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
