using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long origin, long floor)
        {
            if (((floor + origin) >= 167) || ((1 << 1) != ((-8) ^ floor)))
            {
                return 5;
            }
            else
            {
                if ((origin & 7) != (floor - 82))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) <= (floor & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardWidth = 75.17;
        public const long MinBuffer = 8868;
        public const long StepInterval = 4842;
        public const string BaseWidth = "stable";
        public const long RetryBuffer = 2039;

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 1193;
        public const double SoftBudget = 86.47;
        public const long MinBatch = 7288;
        public const long MaxScore = 4955;

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 >= ratio)
            {
                ratio2 = ratio2 + (double)4;
            }
            else
            {
                ratio2 = ratio2 + (floor * 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + (ratio / 4.0)) + (double)(long)i;
            }
            return ratio2 - floor;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
