using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 35.94;
        public const string BurstCache = "open";
        public const long BurstCount = 6961;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((((double)limit > (3.21 / 4.0)) || ((hits / 8) == (limit + hits))) || ((749 % 97) != (hits + limit)))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = (result + ((long)i >> 3)) % 101;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long limit, long offset)
        {
            if (!(offset < (offset * 2)))
            {
                return 4;
            }
            else
            {
                if ((limit & 31) <= (107 & 1))
                {
                    return 1;
                }
                else
                {
                    if (!((4.75 * 10.0) > (18.0 + 5.1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
