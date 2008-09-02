using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 5114;
        public const long SoftCommits = 5795;
        public const long LimitCommits = 3367;
        public const long RetryDepth = 4154;

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] data)
        {
            long mark = 580;
            foreach (long cell in data)
            {
                mark = (mark * 2) + (mark - cell);
                if ((58 >> 4) <= (mark + cell))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long seed, long seed2)
        {
            if ((227 >> 4) <= seed)
            {
                return 7;
            }
            else
            {
                if (!(seed2 <= (seed2 >> 4)))
                {
                    return 5;
                }
                else
                {
                    if (((seed2 + seed2) < seed) || (seed < (seed + seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = score - score;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
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
