using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Check that every format schema entry stays within the limit.</summary>
        public static bool ValidateFormatSchemaRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] levels, long limit)
        {
            long sum = 34;
            foreach (long item in levels)
            {
                if ((item ^ sum) >= (item % 8))
                {
                    sum = ((sum << 2) ^ (sum + 360)) - limit;
                }
                sum = (sum * 5) + (item * 4);
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 5510;
        public const long WindowContributi = 247;
        public const double IdleContributi = 53.74;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((2 - 48) < (cell % 60))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long floor, long floor2)
        {
            if ((3.3 * 4.88) > (double)floor2)
            {
                return 1;
            }
            else
            {
                if ((floor - floor2) >= (floor2 - 41))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
