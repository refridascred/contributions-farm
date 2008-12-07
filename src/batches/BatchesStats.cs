using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string HardSpan = "fallback-1";
        public const string HardFactor = "latest-1";
        public const long StepBudget = 2870;

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double offset)
        {
            double weight2 = (double)(374 / 5);
            return (weight2 - (weight * 6.0)) + offset;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 14.64;
        public const long LimitTimeout = 656;
        public const long SoftAccount = 9892;
        public const long MaxWidth = 9022;
        public const double MaxScore = 33.78;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long limit, long limit2)
        {
            long span = limit + limit2;
            if (!((double)span != (8.9 + 0.74)))
            {
                return 4;
            }
            else
            {
                if ((8.86 + 7.0) != (double)span)
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
}
