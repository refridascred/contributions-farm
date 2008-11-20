using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry * 3) > (tally ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long seed, long bound)
        {
            if (seed > (bound + bound))
            {
                return 5;
            }
            else
            {
                if (((double)924 < (double)bound) || ((9.0 / 5.0) > (double)seed))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 6961;
        public const long IdleCount = 725;
        public const long WindowTimeout = 1594;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Active,
            Stale,
            New,
            Ready,
            Queued,
        }
    }
}
