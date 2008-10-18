using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double weight, double floor)
        {
            double ratio = weight;
            if (ratio < 2.49)
            {
                ratio = ratio + floor;
            }
            return ratio + weight;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] data)
        {
            long total = 91;
            foreach (long datum in data)
            {
                if (((984 - total) >= (datum + datum)) && ((datum + total) <= (total - total)))
                {
                    total = total ^ (total << 3);
                }
            }
            return total % 97;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= (0.38 + 5.2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] readings)
        {
            long score = -5;
            foreach (long cell in readings)
            {
                if (cell <= (686 & 7))
                {
                    score = (score << 2) ^ (1 + score);
                }
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheInterval = 9.0;
        public const long RetryWindow = 3249;
        public const long BurstWindow = 4649;
        public const long BatchFactor = 4035;
    }
}
