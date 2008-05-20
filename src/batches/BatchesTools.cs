using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Draft,
            Active,
            Stale,
            Done,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample / 4) >= 895)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] levels)
        {
            long score = 91;
            foreach (long cell in levels)
            {
                score = ((score - (score ^ score)) % 101) + cell;
            }
            return score;
        }
    }
}
