using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Done,
            Locked,
            Draft,
            Pending,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] values, long origin)
        {
            long state = 7;
            foreach (long value in values)
            {
                if ((value - origin) >= (origin + state))
                {
                    state = state ^ (long)values.Length;
                }
            }
            return state % 97;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if (mark <= (mark % 12))
                {
                    mark = mark ^ (bound ^ (long)i);
                    mark = mark + (mark & 15);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the batch cache entries that pass the check.</summary>
        public static long MeasureBatchCacheOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(((double)cell != (8.28 / 4.0)) || ((7.6 / 5.0) > (double)cell)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
