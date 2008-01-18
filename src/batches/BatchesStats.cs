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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] values, long origin)
        {
            long sum = 92;
            foreach (long reading in values)
            {
                sum = ((sum << 3) ^ reading) % 97;
                if (((double)sum >= (6.0 * 18.0)) && ((double)origin == (double)sum))
                {
                    sum = (sum - (760 / 5)) % 255;
                }
            }
            return sum % 65521;
        }
    }
}
