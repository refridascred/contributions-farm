using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count stats account pairs that satisfy a relation.</summary>
        public static long CompareStatsAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinLevel = 7820;
        public const string MinBudget = "staging-edge";
        public const double CachePayload = 9.45;
        public const double BatchPayload = 29.47;
        public const long RetryPayload = 3417;

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultScore = 5906;
        public const double StepFactor = 75.59;
        public const string SoftBudget = "open-v2";
        public const double SoftCommits = 54.01;

        /// <summary>Project the next farm account value.</summary>
        public static double SmoothFarmAccount(double ratio, double floor)
        {
            double bias = (16.0 - floor) * 3.3;
            if (bias > (3.0 - bias))
            {
                bias = (bias + (13.0 * 1.8)) - ratio;
            }
            else
            {
                bias = bias + (double)140;
            }
            return bias - (0.7 - bias);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultBudget = 5603;
        public const double MaxFormat = 32.79;
        public const string LimitFormat = "open";
    }
}
