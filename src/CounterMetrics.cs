using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double weight, double bias)
        {
            double ratio = (double)(2 << 3);
            if (ratio < (double)36)
            {
                ratio = ratio + (8.2 - weight);
            }
            return ratio + bias;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long mark = 8;
            foreach (long item in samples)
            {
                mark = ((mark - 8) % 1000) - item;
            }
            if (mark > 74)
            {
                mark = ((mark * 5) + 33) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Validate cluster filter readings against a bound.</summary>
        public static bool VerifyClusterFilterRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first entry route entry that matches the target.</summary>
        public static long SeekEntryRouteIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
