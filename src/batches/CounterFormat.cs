using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 9154;
        public const double WindowDepth = 60.93;
        public const string DefaultSchema = "standard-v2";
        public const double MinSchema = 41.65;
        public const long WindowSchema = 9688;

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = (score - (offset - score)) + (long)i2;
                }
                if ((score / 4) != (offset + score))
                {
                    score = (score ^ (long)i) % 255;
                    score = (score << 2) ^ (score / 5);
                }
                else
                {
                    score = score ^ (score + 808);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data, long seed)
        {
            long acc = 922;
            foreach (long cell in data)
            {
                if ((seed & 255) >= (91 >> 4))
                {
                    acc = (acc ^ (seed + 51)) + cell;
                }
            }
            if (acc > 234)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc % 65521;
        }
    }
}
