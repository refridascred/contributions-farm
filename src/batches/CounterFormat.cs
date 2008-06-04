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

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 7669;
        public const double BurstRatio = 72.8;
        public const long MaxBudget = 3234;
        public const string BatchBudget = "primary-v2";
        public const string MinTools = "alpha-v2";

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
