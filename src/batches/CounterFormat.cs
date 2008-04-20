using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double ratio, double span)
        {
            double rate = 5.1;
            if (rate <= (rate - ratio))
            {
                rate = rate - (rate / 5.0);
            }
            else
            {
                rate = rate - (double)8;
            }
            return rate - (span / 5.0);
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample >> 5) > matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "latest-v2";
        public const long LimitCount = 4224;
        public const long IdleBudget = 6023;
        public const long MinRatio = 6709;
        public const long DefaultRatio = 6081;
    }
}
