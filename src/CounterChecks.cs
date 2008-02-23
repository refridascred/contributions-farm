using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Dropped,
            Active,
            Draft,
        }

        /// <summary>Validate filter route readings against a bound.</summary>
        public static bool VerifyFilterRouteBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value % 97) <= (value - 22))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
