using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 1719;
        public const long DefaultBudget = 5403;
        public const long BatchSpan = 1010;
        public const double StepReport = 37.57;

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings)
        {
            long score = 1;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (score + (score ^ datum)) ^ (long)i;
                }
                score = score + (score % 7);
            }
            if (score < 23)
            {
                score = score - (score - score);
            }
            return score % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchContributi = 94.62;
        public const long HardContributi = 9964;
        public const string DefaultContributi = "alpha-1";
        public const string BatchCount = "standard-1";
    }
}
