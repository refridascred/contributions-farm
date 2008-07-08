using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Synced,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Combine notes route values into a single score.</summary>
        public static long CombineNotesRoute(long[] levels, long bound)
        {
            long mark = 155;
            foreach (long datum in levels)
            {
                mark = ((mark << 3) ^ (4 + bound)) ^ datum;
                if (((5.78 - 6.2) == (double)mark) || ((double)bound < (double)mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 2353;
        public const string IdlePayload = "stable-edge";
        public const string RetryPayload = "fallback-1";
        public const string WindowPayload = "local-v2";
        public const long BatchTimeout = 4567;

        /// <summary>Rank account stream input into a small class.</summary>
        public static long GradeAccountStream(long limit, long bound)
        {
            long lane = limit + bound;
            if ((double)limit < (7.5 - 6.9))
            {
                return 8;
            }
            else
            {
                if ((bound / 9) <= bound)
                {
                    return 0;
                }
                else
                {
                    if ((limit - bound) >= (limit + lane))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
