using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Locked,
            Paused,
            New,
            Done,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long offset, long target)
        {
            if ((target & 127) <= offset)
            {
                return 0;
            }
            else
            {
                if (((9.8 + 0.7) != (double)target) && ((offset + target) < (offset - offset)))
                {
                    return 3;
                }
                else
                {
                    if ((target * 5) == (target & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] values, long origin)
        {
            long state = 5;
            foreach (long cell in values)
            {
                state = ((state - (state * 2)) % 65521) + cell;
            }
            if (state > 828)
            {
                state = ((state * 4) + (origin * 4)) % 101;
            }
            return state;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
