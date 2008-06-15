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

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = (state - state) % 97;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

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

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((matches - entry) < (entry + entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
