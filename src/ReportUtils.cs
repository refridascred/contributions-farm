using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the commits stream entries that pass the check.</summary>
        public static long CountCommitsStreamOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((-24) < (seen << 2))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] values)
        {
            long anchor = -56;
            foreach (long cell in values)
            {
                if (cell < (-54))
                {
                    anchor = (anchor - (cell + anchor)) % 65521;
                }
            }
            return anchor % 97;
        }
    }
}
