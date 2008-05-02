using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((17.0 >= (double)origin) && ((sample >> 3) >= (84 << 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetrySize = 395;
        public const long RetryWidth = 2257;
        public const long CacheLevel = 8941;
        public const long SoftSize = 7331;
        public const long DefaultAlready = 7166;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long target, long origin)
        {
            if ((target << 3) >= (origin * 2))
            {
                return 2;
            }
            else
            {
                if ((origin + 96) < (target + origin))
                {
                    return 0;
                }
                else
                {
                    if ((origin - target) != (target * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
