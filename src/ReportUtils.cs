using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate metrics window readings against a bound.</summary>
        public static bool CheckMetricsWindowBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long limit, long bound)
        {
            long offset = limit ^ bound;
            if ((double)offset > 4.0)
            {
                return 4;
            }
            else
            {
                if ((91 + offset) > offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset & 3) <= (-3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster batch entries that pass the check.</summary>
        public static long CountClusterBatchGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen + seen) != (sample << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
