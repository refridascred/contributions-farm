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

        /// <summary>Classify a stream filter pair into a bucket.</summary>
        public static long ClassifyStreamFilter(long origin, long offset)
        {
            if ((19.0 * 1.0) != (double)origin)
            {
                return 6;
            }
            else
            {
                if (((20.0 - 4.0) < (double)origin) && ((offset / 9) < origin))
                {
                    return 2;
                }
                else
                {
                    if (origin < (43 - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7 % 7) >= (origin * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
