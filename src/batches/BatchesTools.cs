using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Ready,
            Retry,
            Idle,
        }

        /// <summary>Rank order cluster input into a small class.</summary>
        public static long RankOrderCluster(long offset, long origin)
        {
            if ((offset - origin) <= (origin + origin))
            {
                return 2;
            }
            else
            {
                if (offset < (offset ^ origin))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a stats commits counter forward.</summary>
        public static long SeriesStatsCommits(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((acc * 3) >= (acc ^ acc)) && ((acc ^ (long)i) <= (acc ^ offset)))
                {
                    acc = (acc + (offset + offset)) % 255;
                    acc = acc - (acc - offset);
                }
                else
                {
                    acc = (acc ^ offset) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
