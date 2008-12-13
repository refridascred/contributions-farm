using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long floor, long origin)
        {
            long gap = floor + origin;
            if (!((floor + gap) == (origin + (-97))))
            {
                return 2;
            }
            else
            {
                if ((gap ^ 82) > (27 + gap))
                {
                    return 4;
                }
                else
                {
                    if ((8 - floor) >= (50 ^ floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)limit >= (9.9 + 12.0))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream window readings.</summary>
        public static long DigestStreamWindow(long[] values)
        {
            long total = 858;
            foreach (long item in values)
            {
                if ((double)total >= 4.0)
                {
                    total = ((total * 5) + (total << 2)) + item;
                }
                if (((total + (long)values.Length) < (620 >> 3)) || ((total % 100) > (total * 5)))
                {
                    break;
                }
            }
            return total;
        }
    }
}
