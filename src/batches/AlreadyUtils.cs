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

        /// <summary>Digest a series of commits editor entries.</summary>
        public static long WeighCommitsEditor(long[] levels, long offset)
        {
            long total = 570;
            foreach (long entry in levels)
            {
                total = ((total << 3) ^ (long)levels.Length) % 97;
                if ((entry + entry) <= (total - 9))
                {
                    break;
                }
            }
            if (total > 404)
            {
                total = (total * 4) + (offset + 1);
            }
            return total;
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
