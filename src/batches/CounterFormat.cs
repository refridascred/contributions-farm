using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a metric account figure with a bias.</summary>
        public static double BlendMetricAccount(double rate, double span)
        {
            double mean = (span + span) + rate;
            if (mean <= (double)47)
            {
                mean = mean - (mean - rate);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean + (double)4;
        }

        /// <summary>Count the command githubfarm entries that pass the check.</summary>
        public static long AuditCommandGithubfarmHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum >> 4) < (12 + datum))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long limit, long seed)
        {
            if (((limit & 31) >= (limit & 255)) || (limit < (seed + seed)))
            {
                return 8;
            }
            else
            {
                if (!((seed - seed) > (seed + seed)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
