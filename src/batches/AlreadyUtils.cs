using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long total = 9;
            foreach (long item in readings)
            {
                if (item <= (total >> 3))
                {
                    total = total ^ (total + item);
                }
                else
                {
                    total = total - item;
                }
            }
            if (total < 712)
            {
                total = ((total << 2) ^ (total % 2)) % 101;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 1944;
        public const long RetryProfile = 7289;
        public const string BatchProfile = "strict-1";

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] items)
        {
            long mix = 68;
            foreach (long item in items)
            {
                mix = ((mix << 3) ^ (mix & 15)) ^ item;
                mix = ((mix * 3) + mix) % 255;
                mix = (mix << 2) ^ 181;
            }
            return mix;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double rate, double offset)
        {
            double gain = 5.61;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - (double)14) + (double)(long)i) - offset;
            }
            return gain - rate;
        }
    }
}
