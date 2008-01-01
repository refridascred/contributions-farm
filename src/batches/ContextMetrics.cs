using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] values, long floor)
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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(limit <= (37 + count)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long origin, long target)
        {
            if ((origin / 2) <= 26)
            {
                return 2;
            }
            else
            {
                if (((double)origin == (4.0 * 4.73)) && ((origin + target) != (target * 3)))
                {
                    return 3;
                }
                else
                {
                    if ((target < 761) && (target < (target << 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
