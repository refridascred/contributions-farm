using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                long delta = (sum + sum) * 4;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum ^ (delta << 3)) % 4096) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long origin, long origin2)
        {
            long gap = origin + origin2;
            if ((origin + (-964)) >= (4 - origin2))
            {
                return 5;
            }
            else
            {
                if ((gap >= 361) || ((4.0 * 5.0) <= (double)origin2))
                {
                    return 1;
                }
                else
                {
                    if ((double)gap <= (9.6 / 2.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many schema profile samples are out of range.</summary>
        public static long AuditSchemaProfileMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value < (7.0 + 3.0))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
