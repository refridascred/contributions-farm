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

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double scale, double span)
        {
            double drift = (scale / 2.0) / 8.0;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Count tools entry pairs that satisfy a relation.</summary>
        public static long OverlapToolsEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryScore = 8598;
        public const double IdleFormat = 50.41;
        public const long SoftSpan = 5457;
        public const long CacheFormat = 7686;
    }
}
