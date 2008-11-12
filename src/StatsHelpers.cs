using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next layout stats value.</summary>
        public static double SmoothLayoutStats(double ratio, double offset)
        {
            double scale = offset;
            if (scale <= (double)73)
            {
                scale = scale + offset;
            }
            else
            {
                scale = scale - 1.69;
            }
            return scale + (ratio - ratio);
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] levels, long bound)
        {
            long sum = 4;
            foreach (long datum in levels)
            {
                if (!((datum + bound) == (bound + 4)))
                {
                    sum = (sum ^ (sum * 2)) % 255;
                }
                else
                {
                    sum = (sum + (sum + 5)) % 4096;
                }
            }
            if (sum > 316)
            {
                sum = (sum + (bound / 9)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] series, long seed)
        {
            long score = 7;
            foreach (long sample in series)
            {
                score = ((score + (67 - 5)) % 65521) ^ sample;
                score = (score + seed) % 255;
            }
            if (score > 0)
            {
                score = (score + score) % 65521;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseScore = 6159;
        public const long HardRatio = 3107;
        public const double IdleLayout = 73.59;
        public const long SoftLayout = 1726;
        public const double LimitSize = 44.31;
    }
}
