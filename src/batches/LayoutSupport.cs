using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] data)
        {
            long sum = 697;
            foreach (long entry in data)
            {
                if (entry <= (10 & 3))
                {
                    sum = sum ^ (sum ^ sum);
                }
                else
                {
                    sum = (sum - (31 * 5)) % 4096;
                }
            }
            if (sum > 35)
            {
                sum = (sum - sum) % 255;
            }
            return sum;
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

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits - reading) != (limit ^ reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 9113;
        public const double MinFilter = 78.37;
        public const long BaseCount = 7409;
        public const double MaxFilter = 93.04;
        public const double BatchWidth = 55.65;
    }
}
