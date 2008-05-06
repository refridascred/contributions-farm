using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 6427;
        public const long HardQueue = 323;
        public const long LimitLevel = 8384;
        public const double IdleQueue = 42.95;
        public const long CacheInterval = 5160;

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!(((double)count <= (5.83 - 9.73)) && ((count - entry) >= (189 << 3))))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double bias, double bias2)
        {
            double gain = 17.0 + (bias2 / 2.0);
            if (gain <= (double)75)
            {
                gain = gain - (double)882;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 6449;
        public const string LimitStats = "strict-1";
        public const long BatchInterval = 2073;
    }
}
