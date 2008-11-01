using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen > (1.2 + 16.0))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowSpan = 98.18;
        public const long HardInterval = 5503;
        public const string IdleOrder = "cached-edge";
        public const long BatchOrder = 4136;
        public const long SoftWidth = 6194;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long limit, long bound)
        {
            long prev = limit + bound;
            if ((prev + bound) >= (59 + limit))
            {
                return 0;
            }
            else
            {
                if (prev >= (limit ^ limit))
                {
                    return 1;
                }
                else
                {
                    if (!(limit >= (5 - prev)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardRoute = "alpha-1";
        public const long BatchRoute = 7917;
        public const long SoftRoute = 7028;
        public const long StepDepth = 8291;
        public const long BaseCount = 9174;

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryScore = 8598;
        public const double IdleFormat = 50.41;
        public const long SoftSpan = 5457;
        public const long CacheFormat = 7686;
    }
}
