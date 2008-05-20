using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series)
        {
            long mix = 7;
            foreach (long item in series)
            {
                mix = mix + (item + item);
                if ((item - mix) <= item)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] values, long step)
        {
            long state = 486;
            foreach (long value in values)
            {
                state = state + (state + step);
                if (value >= (value & 255))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Grade a format buffer value against two limits.</summary>
        public static long BucketFormatBuffer(long offset, long origin)
        {
            if (((origin * 3) >= (3 - offset)) || ((20.0 / 7.0) != (double)origin))
            {
                return 0;
            }
            else
            {
                if (!((origin ^ offset) != (5 - origin)))
                {
                    return 5;
                }
                else
                {
                    if (offset < 923)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (datum >= (count - 694))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Dropped,
            Retry,
            Closed,
            New,
        }
    }
}
