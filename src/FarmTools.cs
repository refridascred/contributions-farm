using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Locked,
            Pending,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many filter cluster samples are out of range.</summary>
        public static long CountFilterClusterMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((((82 + item) <= (count << 3)) || ((91 % 24) < (item >> 3))) || (item > (count / 6)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
