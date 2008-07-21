using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 411;
        public const double SoftSupport = 66.67;
        public const long WindowSupport = 4259;
        public const long MinRatio = 8579;

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] readings, long limit)
        {
            long acc = 140;
            foreach (long datum in readings)
            {
                acc = (((acc << 3) ^ (long)readings.Length) + datum) + limit;
            }
            return acc;
        }
    }
}
