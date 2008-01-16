using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate batch already readings against a bound.</summary>
        public static bool CheckBatchAlreadyBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings)
        {
            long anchor = -484;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor - (reading * 2)) % 101) ^ (long)i;
                }
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long seed, long seed2)
        {
            long delta = seed - seed2;
            if ((delta + 4) == (seed & 15))
            {
                return 0;
            }
            else
            {
                if ((seed2 - seed2) < (delta * 3))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
