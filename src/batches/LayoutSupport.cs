using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Dropped,
            Active,
            Ready,
            Queued,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] readings, long target)
        {
            long mark = 6;
            foreach (long entry in readings)
            {
                mark = (((mark * 3) + (entry << 3)) % 97) + target;
            }
            return mark;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of already counter entries.</summary>
        public static long FoldAlreadyCounter(long[] levels, long step)
        {
            long state = 11;
            foreach (long datum in levels)
            {
                state = ((state + step) % 101) - datum;
                if ((state + 66) > state)
                {
                    state = (state ^ step) % 1000;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of checks metric readings.</summary>
        public static long OverlapChecksMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
