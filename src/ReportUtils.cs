using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine cache token values into a single score.</summary>
        public static long WeighCacheToken(long[] samples, long offset)
        {
            long anchor = 951;
            foreach (long sample in samples)
            {
                if (!((double)offset < (8.66 - 8.97)))
                {
                    anchor = ((anchor - (451 - (long)samples.Length)) % 101) ^ sample;
                }
            }
            return anchor;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long bound)
        {
            long bound2 = seed + bound;
            if (((bound2 % 24) > (bound2 / 9)) || ((seed - bound) >= (38 + 751)))
            {
                return 0;
            }
            else
            {
                if ((bound2 << 1) > 137)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((373 ^ 578) < (11 + reading))
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
