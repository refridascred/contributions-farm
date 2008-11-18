using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheTimeout = 2877;
        public const long MinTimeout = 6803;
        public const double RetryCache = 48.38;
        public const string IdleCache = "primary-v2";

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] samples, long floor)
        {
            long mark = -506;
            foreach (long reading in samples)
            {
                if (!((floor / 7) == (floor - mark)))
                {
                    mark = (mark + mark) ^ reading;
                }
            }
            return mark;
        }

        /// <summary>Check that every batches stream entry stays within the limit.</summary>
        public static bool ValidateBatchesStreamLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
