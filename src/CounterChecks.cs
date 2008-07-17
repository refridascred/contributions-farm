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

        /// <summary>Classify a schema stats pair into a bucket.</summary>
        public static long SortSchemaStats(long step, long limit)
        {
            long slot = step + limit;
            if (step > (limit & 3))
            {
                return 7;
            }
            else
            {
                if ((limit * 5) >= slot)
                {
                    return 2;
                }
                else
                {
                    if ((step + step) >= (79 + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((slot % 60) > 80) || ((7.5 / 8.0) != (double)limit))
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
