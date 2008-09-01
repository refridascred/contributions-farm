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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)(long)samples.Length == (14.0 / 8.0))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
