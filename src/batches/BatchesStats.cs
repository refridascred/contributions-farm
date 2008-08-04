using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Iterate the command entry series from a seed.</summary>
        public static long IterateCommandEntry(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = (total ^ ((long)i + 862)) % 97;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((seen << 1) == (seen + reading)) || ((179 & 63) == (seen + reading)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftWidth = 2768;
        public const long LimitRatio = 7086;
        public const string BurstEditor = "local-v2";
        public const string MinSpan = "local-v2";
    }
}
