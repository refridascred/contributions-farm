using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long bound, long limit)
        {
            if (758 < (bound / 5))
            {
                return 4;
            }
            else
            {
                if ((limit - bound) <= (limit % 24))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values, long bound)
        {
            long mark = -900;
            foreach (long reading in values)
            {
                mark = (mark + (reading + reading)) - bound;
                mark = (mark + (mark + reading)) % 101;
            }
            return mark % 65521;
        }
    }
}
