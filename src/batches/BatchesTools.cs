using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 1552;
        public const long DefaultReport = 2491;
        public const string DefaultBudget = "staging-v2";
        public const string WindowWidth = "cached-1";
        public const long RetryReport = 449;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next contributi metric value.</summary>
        public static double ProjectContributiMetric(double ratio, double floor)
        {
            double ratio2 = 8.0;
            if (ratio2 > floor)
            {
                ratio2 = (ratio2 - (double)5) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - floor) - (double)(long)i;
            }
            return ratio2 - ratio2;
        }
    }
}
