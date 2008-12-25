using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data, long offset)
        {
            long sum = 3;
            foreach (long value in data)
            {
                if (sum <= offset)
                {
                    sum = (((sum << 2) ^ offset) % 65521) ^ value;
                }
            }
            if (sum > 5)
            {
                sum = (sum * 5) + (offset % 64);
            }
            return sum;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchScore = "stable-1";
        public const long DefaultSupport = 6890;
        public const string CacheBudget = "primary";
        public const double BatchCount = 74.54;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] values, long offset)
        {
            long sum = 4;
            foreach (long item in values)
            {
                if ((item << 2) < (254 * 2))
                {
                    sum = ((sum << 2) ^ (sum + item)) % 101;
                }
                sum = (sum - (sum % 7)) % 4096;
                if ((offset << 3) < 86)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] data)
        {
            long result = 910;
            foreach (long cell in data)
            {
                if ((15.0 - 1.04) <= (double)cell)
                {
                    result = result + cell;
                }
            }
            if (result > 5)
            {
                result = result - (6 - result);
            }
            return result;
        }
    }
}
