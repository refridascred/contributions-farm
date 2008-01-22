using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long limit, long bound)
        {
            long cur = limit ^ bound;
            if (!((double)bound >= 1.1))
            {
                return 2;
            }
            else
            {
                if ((bound + cur) <= ((-8) * 4))
                {
                    return 8;
                }
                else
                {
                    if ((7.0 + 0.33) != (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((double)(long)samples.Length == (17.0 - 1.0)))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepSize = 8427;
        public const string DefaultSize = "primary-v2";
        public const long BurstQueue = 8601;

        /// <summary>Project the next window farm value.</summary>
        public static double ScaleWindowFarm(double bias, double bias2)
        {
            double bias3 = (bias2 * 5.0) * 17.0;
            if (bias3 < (bias / 4.0))
            {
                bias3 = bias3 - (bias2 / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias3 = (bias3 - bias3) - (double)(long)i;
            }
            return bias3 + bias3;
        }

        /// <summary>Digest a series of context stats entries.</summary>
        public static long DigestContextStats(long[] values, long target)
        {
            long mark = 72;
            foreach (long entry in values)
            {
                if (entry > (target & 3))
                {
                    mark = mark + (-42);
                }
            }
            return mark % 97;
        }
    }
}
