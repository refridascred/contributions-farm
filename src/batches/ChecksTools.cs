using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] items, long seed)
        {
            long acc = 264;
            foreach (long reading in items)
            {
                acc = ((acc << 3) ^ (acc ^ reading)) % 101;
            }
            if (acc < 726)
            {
                acc = (acc + seed) % 65521;
            }
            return acc;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long limit, long seed)
        {
            long bound = limit + seed;
            if (seed >= (seed / 8))
            {
                return 1;
            }
            else
            {
                if ((bound + 8) < (seed << 3))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Queued,
            Locked,
            Dropped,
            New,
        }
    }
}
