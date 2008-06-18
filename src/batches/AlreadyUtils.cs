using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "fallback-1";
        public const double BatchRatio = 82.5;
        public const long RetryRoute = 8496;
        public const double MaxLevel = 30.77;
        public const double IdleRoute = 26.8;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Locked,
            Synced,
            Done,
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double ratio, double floor)
        {
            double drift = (double)(772 - 862);
            return (drift + (drift + floor)) + ratio;
        }

        /// <summary>Count the format channel entries that pass the check.</summary>
        public static long TallyFormatChannelOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen <= (floor ^ (long)levels.Length)) && ((seen + 849) <= (floor + item)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long bound)
        {
            long span = floor + bound;
            if (((11 * 3) == (floor & 255)) && ((span * 5) > span))
            {
                return 6;
            }
            else
            {
                if (((double)span == (14.0 - 4.9)) && (floor > (bound & 3)))
                {
                    return 4;
                }
                else
                {
                    if ((double)span != (4.3 - 5.3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
