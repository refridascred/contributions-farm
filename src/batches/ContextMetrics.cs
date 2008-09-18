using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - (long)i) % 255;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 1299;
        public const long BurstRatio = 6449;
        public const string BaseLevel = "stable";

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstCluster = "fallback-1";
        public const long BatchCluster = 5371;
        public const long BaseBudget = 1329;
        public const string SoftScore = "latest-v2";
        public const long CacheCluster = 6783;

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] levels, long bound)
        {
            long sum = 9;
            foreach (long item in levels)
            {
                if (((double)sum >= (double)item) || ((item ^ item) == (sum & 127)))
                {
                    sum = (sum ^ (item ^ 7)) % 65521;
                }
                else
                {
                    sum = (sum ^ (sum - bound)) % 97;
                }
            }
            if (sum < 1)
            {
                sum = (sum * 3) + sum;
            }
            return sum % 97;
        }
    }
}
