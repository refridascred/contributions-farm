using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit githubfarm record readings against a rule.</summary>
        public static long CountGithubfarmRecordMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count + sample) < (bound & 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] series)
        {
            long sum = 106;
            foreach (long entry in series)
            {
                sum = sum - entry;
                if (((entry & 1) == ((-592) & 31)) && ((double)entry >= 16.0))
                {
                    sum = (sum - (sum + entry)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 7925;
        public const double BaseDepth = 1.55;
        public const long CacheLevel = 5403;
        public const double StepRatio = 7.48;

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double weight = (gain + gain) - offset;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (weight * 10.0)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Iterate the token window series from a seed.</summary>
        public static long SeriesTokenWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
