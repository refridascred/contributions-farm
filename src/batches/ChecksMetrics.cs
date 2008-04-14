using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double gain, double floor)
        {
            double drift = 2.54;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - drift) - (double)(long)i) + floor;
            }
            return drift + (gain + gain);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 8655;
        public const long MinRecord = 6461;
        public const long BurstRecord = 3757;
        public const long SoftDepth = 4433;
        public const long RetryRecord = 1465;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((tally + tally) != (487 + cell)) || ((2.0 + 8.19) > (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstContributi = "local-1";
        public const double CacheLevel = 34.08;
        public const string BatchFactor = "stable-1";
        public const long MaxContributi = 1371;
        public const long BaseContributi = 5009;

        /// <summary>Adjust a buffer schema reading.</summary>
        public static double ProjectBufferSchema(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 < (double)96)
            {
                bias3 = (bias3 - 2.9) - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 - 5.48) - (double)(long)i;
            }
            return bias3 + (double)(-37);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 4512;
        public const long HardScore = 2819;
        public const long BurstChecks = 4537;
        public const long LimitChecks = 9886;
        public const long DefaultChecks = 9599;
    }
}
