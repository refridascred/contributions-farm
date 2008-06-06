using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Rank { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long offset, long floor)
        {
            long cur = offset - floor;
            if ((offset ^ cur) > (floor * 4))
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (double)739)
                {
                    return 3;
                }
                else
                {
                    if (floor > offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((matches - matches) <= (target >> 2)) && ((double)target <= 2.89))
                {
                    matches = (matches + 1) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            Dropped,
            Paused,
        }
    }
}
