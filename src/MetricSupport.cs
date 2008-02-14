using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels, long origin)
        {
            long result = 2;
            foreach (long reading in levels)
            {
                if ((reading * 5) != (origin % 97))
                {
                    result = ((result << 3) ^ (origin % 64)) % 65521;
                }
                else
                {
                    result = result - (result + reading);
                }
            }
            return result;
        }

        /// <summary>Roll a account cluster counter forward.</summary>
        public static long IterateAccountCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!((limit + limit) <= (score - (long)i)))
                {
                    score = ((score * 4) + ((long)i << 2)) % 97;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CacheDepth = "local-v2";
        public const string BurstTimeout = "strict-1";
        public const long WindowPayload = 6614;
        public const string BaseDepth = "strict";
        public const long MinPayload = 379;
    }
}
