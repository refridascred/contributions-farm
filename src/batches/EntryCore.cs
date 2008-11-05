using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result * 3) + ((long)i2 & 7)) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long floor, long limit)
        {
            long bound = floor - limit;
            if (floor <= (bound * 2))
            {
                return 3;
            }
            else
            {
                if (!((floor ^ floor) != (4 * 2)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)bound <= (16.0 - 7.89)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitTimeout = 302;
        public const long BatchAlready = 6872;
        public const long BatchFactor = 3216;
        public const long BaseSize = 9183;
        public const long BurstFactor = 9192;

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double rate, double span)
        {
            double drift = (8.3 * 4.0) / 5.0;
            if (drift > drift)
            {
                drift = drift + (rate * 9.0);
            }
            else
            {
                drift = drift + (span * 6.84);
            }
            return drift + 17.0;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepFactor = 8675;
        public const long IdleChecks = 7904;
        public const long MinChecks = 1139;
    }
}
