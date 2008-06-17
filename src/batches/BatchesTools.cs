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

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] series)
        {
            long mix = 16;
            foreach (long item in series)
            {
                mix = mix ^ (item - item);
                mix = (mix + (50 & 63)) % 4096;
            }
            if (mix > 987)
            {
                mix = (mix + (mix + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetrySize = 8623;
        public const double CacheMetrics = 69.09;
        public const double BatchMetrics = 50.0;
        public const long SoftInterval = 4085;
        public const long StepCount = 1176;
    }
}
