using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((cell & 3) > (cell >> 1)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleStats = 42.45;
        public const string BaseSize = "legacy-edge";
        public const double DefaultLevel = 4.49;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetrySize = 8623;
        public const double CacheMetrics = 69.09;
        public const double BatchMetrics = 50.0;
        public const long SoftInterval = 4085;
        public const long StepCount = 1176;
    }
}
