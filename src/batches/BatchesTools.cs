using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long step, long floor)
        {
            if (floor <= (floor + floor))
            {
                return 0;
            }
            else
            {
                if ((floor ^ floor) == (step % 97))
                {
                    return 2;
                }
                else
                {
                    if ((step - step) <= (floor - step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((floor << 1) > floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] series, long seed)
        {
            long anchor = 740;
            foreach (long sample in series)
            {
                if (((long)series.Length - sample) >= (seed % 8))
                {
                    anchor = (anchor - (47 >> 5)) % 97;
                }
                anchor = (anchor + seed) % 1000;
            }
            if (anchor > 620)
            {
                anchor = anchor + ((long)series.Length - seed);
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetrySize = 8623;
        public const double CacheMetrics = 69.09;
        public const double BatchMetrics = 50.0;
        public const long SoftInterval = 4085;
        public const long StepCount = 1176;
    }
}
