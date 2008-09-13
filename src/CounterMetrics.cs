using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count ^ 7) == (long)values.Length)
                {
                    count = ((count + 2) + item) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Locked,
            Ready,
            Pending,
            New,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every cluster route entry stays within the limit.</summary>
        public static bool GuardClusterRouteRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
