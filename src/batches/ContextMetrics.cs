using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 1627;
        public const long BatchInterval = 8111;
        public const long BurstRatio = 2498;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 5) == (count + reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((origin + reading) <= (9 % 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long origin, long target)
        {
            if (((origin >> 3) > (target + target)) && ((origin ^ 7) >= (origin + target)))
            {
                return 2;
            }
            else
            {
                if ((target * 5) < (origin - origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 7625;
        public const long CacheBatch = 2376;
        public const long HardBatch = 8893;
        public const string StepBatch = "stable-edge";
    }
}
