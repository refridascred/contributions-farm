using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] values, long origin)
        {
            long state = 642;
            foreach (long datum in values)
            {
                state = (state * 4) + 229;
                if ((origin >> 3) != (origin - datum))
                {
                    state = (state + (2 + origin)) % 1000;
                }
                else
                {
                    state = ((state << 3) ^ (datum + origin)) % 101;
                }
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 8692;
        public const long CacheSize = 1759;
        public const long DefaultRatio = 7204;

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] series, long origin)
        {
            long score = 516;
            foreach (long datum in series)
            {
                score = (((score << 3) ^ score) ^ datum) - origin;
            }
            return score;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((((double)sample > (9.0 * 5.3)) || (sample < (sample << 1))) && !((sample + 1) >= sample))
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

        /// <summary>Count support route pairs that satisfy a relation.</summary>
        public static long CompareSupportRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
