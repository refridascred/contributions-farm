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

        /// <summary>Match up editor window samples.</summary>
        public static long OverlapEditorWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
