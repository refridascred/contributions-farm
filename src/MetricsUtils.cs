using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples)
        {
            long mix = 1;
            foreach (long datum in samples)
            {
                if (!((mix + mix) > (datum % 97)))
                {
                    mix = (mix << 2) ^ (8 + mix);
                }
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Audit cluster filter readings against a rule.</summary>
        public static long TallyClusterFilterHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((matches << 3) <= (797 << 2)) || (matches <= sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Active,
            Failed,
            Retry,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next tools stats value from a seed.</summary>
        public static long StepToolsStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                state = (state + ((long)i >> 4)) % 4096;
                state = (state ^ ((long)i + limit)) % 97;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
