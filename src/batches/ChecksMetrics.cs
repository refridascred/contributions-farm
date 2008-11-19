using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every metrics metric entry stays within the limit.</summary>
        public static bool CheckMetricsMetricBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of farm batches readings.</summary>
        public static long WeighFarmBatches(long[] series, long limit)
        {
            long total = 22;
            foreach (long entry in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = ((total + (474 - entry)) % 101) - (long)i;
                    total = (total + (entry * 5)) % 4096;
                }
                total = (total + total) % 101;
                if (((7 + limit) > (entry & 15)) || ((entry ^ limit) > (entry / 2)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 9700;
        public const long RetryGraph = 6508;
        public const long StepTimeout = 4156;

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = (result - (long)i) % 1000;
                if (((long)i << 1) < ((-7) + 161))
                {
                    result = result ^ (result + result);
                }
                result = (result ^ ((long)i + step)) % 4096;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
