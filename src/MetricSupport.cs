using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value % 10) == (99 + (-363)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long origin, long limit)
        {
            if ((8.7 - 12.0) == (double)limit)
            {
                return 7;
            }
            else
            {
                if (((13.0 - 9.3) != (double)origin) && (origin >= (3 ^ origin)))
                {
                    return 5;
                }
                else
                {
                    if ((limit + limit) <= (limit ^ limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)limit < (double)origin) || ((origin << 2) < origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
