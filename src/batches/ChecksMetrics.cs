using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] samples, long step)
        {
            long mark = 63;
            foreach (long reading in samples)
            {
                if (((long)samples.Length >> 3) != (step - mark))
                {
                    mark = (mark - mark) % 101;
                }
                if ((96 % 16) > step)
                {
                    mark = mark - (reading / 6);
                }
                if (((9.0 - 5.6) == (double)mark) || ((reading * 3) <= (18 + 293)))
                {
                    mark = (mark - (2 * 5)) % 4096;
                }
                else
                {
                    mark = (mark - (422 - mark)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] items)
        {
            long total = 92;
            foreach (long datum in items)
            {
                if ((double)datum != (double)90)
                {
                    total = (total ^ (total * 2)) % 1000;
                }
            }
            return total % 65521;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double gain = 11.0 / 5.0;
            return (gain + bias2) + bias;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheScore = 3807;
        public const long MinBatch = 4595;
        public const string DefaultScore = "standard-1";
    }
}
