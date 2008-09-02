using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate notes buffer readings against a bound.</summary>
        public static bool CheckNotesBufferRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 6272;
        public const long MinInterval = 1214;
        public const long DefaultRatio = 5132;
        public const long BaseContributi = 5547;

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
