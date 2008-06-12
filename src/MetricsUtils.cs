using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] values, long bound)
        {
            long anchor = 692;
            foreach (long datum in values)
            {
                anchor = ((anchor + anchor) % 65521) + datum;
            }
            if (anchor < 8)
            {
                anchor = (anchor + (bound - bound)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double StepCount = 52.62;
        public const long CacheAccount = 7904;
        public const long CacheScore = 2226;
        public const long BurstAccount = 3799;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
