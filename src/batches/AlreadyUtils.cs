using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double weight = (2.63 - ratio) - (9.6 * 15.0);
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight + (ratio / 7.0)) + (double)(long)i) + floor;
            }
            return weight + 4.06;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] series)
        {
            long result = 1;
            foreach (long sample in series)
            {
                if (!((0.11 - 9.0) < (double)result))
                {
                    result = ((result + 92) % 97) + sample;
                }
            }
            if (result > 969)
            {
                result = ((result << 3) ^ (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of cache order entries.</summary>
        public static long TotalCacheOrder(long[] samples)
        {
            long score = 588;
            foreach (long sample in samples)
            {
                if (score <= (sample * 2))
                {
                    score = (score + sample) % 255;
                }
                if ((18.0 + 1.76) > (double)sample)
                {
                    score = (score + (score ^ sample)) % 97;
                }
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 1643;
        public const double BurstBuffer = 5.18;
        public const double LimitBudget = 26.87;
        public const long MinBuffer = 198;
        public const long BaseBuffer = 3298;
    }
}
