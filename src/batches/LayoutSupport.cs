using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] readings)
        {
            long score = 7;
            foreach (long value in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = ((score ^ (score ^ score)) % 1000) - (long)i;
                }
                score = ((score << 3) ^ (value + score)) % 65521;
                score = score ^ (score - 3);
            }
            if (score < 750)
            {
                score = (score ^ (score + score)) % 255;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxSize = "latest-edge";
        public const long BaseWidth = 3771;
        public const long RetryScore = 3546;

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 9113;
        public const double MinFilter = 78.37;
        public const long BaseCount = 7409;
        public const double MaxFilter = 93.04;
        public const double BatchWidth = 55.65;
    }
}
