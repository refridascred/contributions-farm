using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 4.23;
        public const double IdleFilter = 83.66;
        public const string BaseFilter = "strict-v2";

        /// <summary>Locate a notes session reading by value.</summary>
        public static long SeekNotesSessionIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Stale,
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long limit)
        {
            long cur = offset - limit;
            if ((limit + cur) >= (limit / 2))
            {
                return 6;
            }
            else
            {
                if (((limit + limit) < limit) && ((double)offset != (6.2 - 7.57)))
                {
                    return 0;
                }
                else
                {
                    if ((offset + cur) <= (offset - cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
