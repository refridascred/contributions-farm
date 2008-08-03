using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((2.0 - 9.3) != (double)hits)
                {
                    hits = ((hits + 3) + value) + step;
                }
            }
            return hits;
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long step, long target)
        {
            long edge = step ^ target;
            if (853 <= edge)
            {
                return 6;
            }
            else
            {
                if (((double)target >= (15.0 / 4.0)) && ((edge % 64) <= (edge & 15)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Pending,
            Retry,
            Queued,
        }
    }
}
