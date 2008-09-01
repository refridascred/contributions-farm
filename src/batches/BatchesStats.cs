using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Queued,
            Closed,
            Ready,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count + value) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((double)tally <= 12.0))
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long floor, long origin)
        {
            long gap = floor ^ origin;
            if (gap >= 8)
            {
                return 2;
            }
            else
            {
                if ((origin ^ origin) <= floor)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
