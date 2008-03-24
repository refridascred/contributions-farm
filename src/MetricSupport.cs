using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a format cluster pair into a bucket.</summary>
        public static long SortFormatCluster(long step, long limit)
        {
            long cur = step - limit;
            if ((limit / 7) < (limit << 1))
            {
                return 8;
            }
            else
            {
                if ((cur ^ limit) < (1 & 63))
                {
                    return 3;
                }
                else
                {
                    if ((step ^ 2) < (step % 8))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up token stream samples.</summary>
        public static long OverlapTokenStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many context profile samples are out of range.</summary>
        public static long CountContextProfileOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((7.02 * 5.7) <= (double)step))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
