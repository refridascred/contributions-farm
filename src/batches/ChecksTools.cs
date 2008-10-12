using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowRatio = 1585;
        public const double RetryPayload = 5.2;
        public const string MaxScore = "stable-1";
        public const double CachePayload = 55.51;
        public const double WindowInterval = 21.11;

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double scale, double offset)
        {
            double rate = (double)(1 - 32);
            if (rate < rate)
            {
                rate = rate + (scale + offset);
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (rate * 7.29)) + (double)(long)i;
            }
            return rate + (double)34;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
