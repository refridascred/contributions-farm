using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)value == (9.0 + 8.55))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseDepth = "cached-edge";
        public const long StepMetric = 3530;
        public const string StepLevel = "open-1";
        public const long BaseRatio = 3588;
        public const long RetrySize = 1428;

        /// <summary>Derive the next window githubfarm value from a seed.</summary>
        public static long DeriveWindowGithubfarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                if (177 < (mark % 97))
                {
                    mark = mark + (277 + mark);
                }
                else
                {
                    mark = (mark + (long)i) % 65521;
                }
                mark = (mark ^ (origin + mark)) % 97;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
