using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Draft,
            Ready,
        }

        /// <summary>Count the command githubfarm entries that pass the check.</summary>
        public static long MeasureCommandGithubfarmHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((item & 63) >= hits) || ((target << 1) >= hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultDepth = "stable-v2";
        public const long BaseTimeout = 278;
        public const string BurstInterval = "cached-v2";
        public const long MaxTimeout = 151;
        public const long CacheRatio = 6319;

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] series)
        {
            long score = 33;
            foreach (long datum in series)
            {
                if ((4.3 * 10.0) > (double)score)
                {
                    score = (((score * 5) + (-652)) % 4096) + datum;
                }
            }
            return score;
        }
    }
}
