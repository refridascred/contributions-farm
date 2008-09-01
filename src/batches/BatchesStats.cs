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

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
