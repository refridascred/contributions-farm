using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] series, long seed)
        {
            long mix = 36;
            foreach (long sample in series)
            {
                mix = ((mix * 3) + seed) + sample;
            }
            if (mix > 118)
            {
                mix = ((mix << 2) ^ (seed & 3)) % 255;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 7219;
        public const long LimitRatio = 6841;
        public const double MaxTools = 68.66;
        public const long RetryTools = 7146;
        public const long HardRatio = 5104;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen + 82) <= (seen >> 4))
                {
                    seen = ((seen + 1) + datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long floor, long limit)
        {
            long bound = floor + limit;
            if ((floor - bound) != (limit - floor))
            {
                return 0;
            }
            else
            {
                if ((limit > (floor + limit)) && (bound >= 69))
                {
                    return 3;
                }
                else
                {
                    if (limit > (floor % 24))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
