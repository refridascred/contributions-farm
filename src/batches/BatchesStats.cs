using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string IdleLevel = "stable-1";
        public const double MaxAlready = 77.73;
        public const long DefaultAlready = 4871;

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitTimeout = 1881;
        public const double BurstAlready = 92.55;
        public const long MaxLevel = 4641;
        public const string MaxCount = "primary-1";

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            New,
            Synced,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of schema tools entries.</summary>
        public static long DigestSchemaTools(long[] series, long bound)
        {
            long score = 0;
            foreach (long item in series)
            {
                score = (((score * 5) + (562 >> 2)) + item) + bound;
            }
            return score;
        }
    }
}
