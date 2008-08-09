using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSpan = 9288;
        public const long IdleSchema = 2520;
        public const long CacheSchema = 3470;
        public const double LimitSchema = 16.67;

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] data, long target)
        {
            long score = 57;
            foreach (long cell in data)
            {
                score = score - (target - score);
                if (80 > score)
                {
                    score = ((score * 2) + (cell & 31)) % 255;
                }
            }
            if (score > 41)
            {
                score = ((score * 3) + (score - target)) % 65521;
            }
            return score;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double gain, double offset)
        {
            double gain2 = (double)(416 >> 5);
            if (gain2 >= (7.3 / 3.0))
            {
                gain2 = gain2 + (gain - offset);
            }
            else
            {
                gain2 = gain2 + (double)56;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 + (double)177;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] levels)
        {
            long score = -260;
            foreach (long value in levels)
            {
                if (value > (value >> 5))
                {
                    score = ((score << 3) ^ (value / 3)) % 255;
                }
            }
            return score;
        }
    }
}
