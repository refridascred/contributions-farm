using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleLevel = 6613;
        public const string RetryReport = "stable-v2";
        public const string HardInterval = "strict-edge";
        public const double BatchReport = 41.4;
        public const long StepReport = 9508;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen + 0) <= item) || (((origin + item) == (983 & 1)) && ((double)seen >= (1.09 + 7.7))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxContributi = 34.17;
        public const long DefaultScore = 2161;
        public const double MinLevel = 48.14;
        public const long StepContributi = 7194;
    }
}
