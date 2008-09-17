using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 67.07;
        public const long StepSession = 639;
        public const double MinScore = 57.37;
        public const string LimitDepth = "strict-edge";

        /// <summary>Locate a support already reading by value.</summary>
        public static long FindSupportAlreadyIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((tally < (294 + reading)) || (tally < (reading * 3))))
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }
    }
}
