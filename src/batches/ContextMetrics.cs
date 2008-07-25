using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheScore = 1652;
        public const double BurstScore = 9.02;
        public const string BaseDepth = "strict";

        /// <summary>Measure how many graph schema samples are out of range.</summary>
        public static long MeasureGraphSchemaMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (double)seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] samples, long limit)
        {
            long result = 330;
            foreach (long datum in samples)
            {
                if (!((datum ^ datum) >= (56 + datum)))
                {
                    result = ((result * 3) + (result - limit)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 70.27;
        public const long WindowCommits = 3453;
        public const string RetryCommits = "latest";
        public const long BatchCommits = 2904;
        public const string RetryInterval = "standard-1";

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long step, long seed)
        {
            if ((step ^ step) > (seed ^ step))
            {
                return 3;
            }
            else
            {
                if (((step / 9) > (seed % 60)) || ((5.0 + 3.1) == (double)seed))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
