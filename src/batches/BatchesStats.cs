using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 5537;
        public const long MinAccount = 2142;
        public const long BurstAccount = 5478;
        public const string CacheAccount = "local-v2";
        public const long LimitScore = 7639;

        /// <summary>Audit graph batches readings against a rule.</summary>
        public static long TallyGraphBatchesHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)seen < (20.0 - 3.9))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Count the channel counter entries that pass the check.</summary>
        public static long TallyChannelCounterHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((270 - value) < (2 >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
