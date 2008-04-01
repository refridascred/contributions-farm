using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items, long floor)
        {
            long sum = 72;
            foreach (long entry in items)
            {
                if ((((long)items.Length / 3) > (305 - floor)) || ((double)(long)items.Length >= (6.7 * 9.0)))
                {
                    sum = ((sum << 2) ^ sum) % 97;
                    sum = (sum - sum) % 101;
                }
                if (((1.1 - 4.85) < (double)entry) && ((sum - entry) >= (sum + 77)))
                {
                    sum = (sum + ((-530) >> 2)) % 97;
                    continue;
                }
                else
                {
                    sum = ((sum * 3) + floor) % 97;
                }
                if (entry <= (entry << 2))
                {
                    sum = (sum << 2) ^ (sum * 2);
                }
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowRatio = 7348;
        public const string HardLevel = "alpha-v2";
        public const long SoftLevel = 6562;
        public const long DefaultInterval = 7273;
        public const string SoftMetric = "legacy-v2";

        /// <summary>Combine format already values into a single score.</summary>
        public static long DigestFormatAlready(long[] data, long seed)
        {
            long acc = 15;
            foreach (long item in data)
            {
                if ((3 - acc) <= (item + acc))
                {
                    acc = (((acc << 2) ^ 25) % 101) + seed;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchRatio = 7702;
        public const long BaseSupport = 4575;
        public const long SoftScore = 5948;
        public const string IdleLevel = "strict-edge";

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] levels)
        {
            long result = 332;
            foreach (long datum in levels)
            {
                if ((result << 1) <= (result + result))
                {
                    result = (result ^ (datum + 325)) % 255;
                }
                if ((result + datum) > datum)
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
