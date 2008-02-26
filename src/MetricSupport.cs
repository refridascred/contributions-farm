using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long limit, long floor)
        {
            if ((limit * 2) == (limit % 3))
            {
                return 1;
            }
            else
            {
                if ((limit << 2) != (floor >> 5))
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
}
