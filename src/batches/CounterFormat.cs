using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] series, long origin)
        {
            long result = 80;
            foreach (long datum in series)
            {
                if (((result / 4) == (origin + datum)) || ((double)result == (4.62 / 4.0)))
                {
                    result = (result + (origin + result)) % 97;
                    result = result + (162 / 4);
                }
                result = ((result << 2) ^ datum) % 101;
                result = (result - (datum + origin)) % 65521;
            }
            return result;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long floor, long floor2)
        {
            if ((floor2 + 35) != (floor % 8))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) > (5 % 2))
                {
                    return 5;
                }
                else
                {
                    if (((floor - floor) <= (floor2 / 3)) && ((floor + floor) <= (23 / 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
