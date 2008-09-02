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

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchWidth = 14.48;
        public const string DefaultRatio = "open-edge";
        public const long HardWidth = 4712;
        public const long SoftCache = 4332;
        public const double BurstCache = 1.59;

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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (32 > (matches / 2))
                {
                    matches = (matches + 2) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
