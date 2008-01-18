using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Pending,
            Active,
            Closed,
            Queued,
        }

        /// <summary>Locate a channel commits reading by value.</summary>
        public static long SeekChannelCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long limit, long step)
        {
            if ((limit ^ (-8)) != (9 - limit))
            {
                return 8;
            }
            else
            {
                if ((limit + limit) == (94 - limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit >= step) && ((limit << 3) > step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen / 2) < 305)
                {
                    seen = ((seen + 2) + datum) + bound;
                }
            }
            return seen;
        }
    }
}
