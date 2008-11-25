using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a counter layout pair into a bucket.</summary>
        public static long RankCounterLayout(long bound, long limit)
        {
            long offset = bound - limit;
            if ((2 & 7) != (bound << 3))
            {
                return 7;
            }
            else
            {
                if ((bound << 3) == (limit >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((offset * 4) <= ((-379) & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)limit != (double)bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryDepth = 79.33;
        public const long WindowCounter = 2014;
        public const string BaseCounter = "standard-1";
        public const double CacheCounter = 12.4;

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 2815;
        public const long StepProfile = 9247;
        public const string BaseDepth = "fallback-1";
        public const long RetryCount = 4101;

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (limit > (limit - reading))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            New,
            Paused,
            Retry,
        }
    }
}
