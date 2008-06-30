using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long floor)
        {
            long state = 81;
            foreach (long item in data)
            {
                if (((double)item != (0.5 + 6.9)) && ((state + 430) <= (state + item)))
                {
                    state = state - (item / 7);
                }
                state = (state - (floor & 31)) % 4096;
                if ((item % 16) >= (item - state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading / 7) >= tally)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}
