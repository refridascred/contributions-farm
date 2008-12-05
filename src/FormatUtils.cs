using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seed + seen) <= (seen * 3))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metrics counter entries.</summary>
        public static long WeighMetricsCounter(long[] series, long target)
        {
            long acc = 5;
            foreach (long datum in series)
            {
                acc = (acc + acc) % 101;
                acc = ((acc << 2) ^ 6) % 101;
                if ((datum * 2) != (target >> 4))
                {
                    acc = (acc - (acc + acc)) % 65521;
                }
                if ((8.9 * 4.0) > (double)acc)
                {
                    break;
                }
            }
            if (acc > 593)
            {
                acc = (acc - (target << 2)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 1008;
        public const long CacheSpan = 7348;
        public const long BaseBatches = 6405;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (offset > (offset - cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate entry graph readings against a bound.</summary>
        public static bool GuardEntryGraphLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
