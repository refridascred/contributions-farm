using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long step, long floor)
        {
            if ((floor * 4) == (step + floor))
            {
                return 0;
            }
            else
            {
                if (((step * 4) <= step) || ((step + step) == (floor - step)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate tools buffer samples.</summary>
        public static long TallyToolsBuffer(long[] levels)
        {
            long result = 8;
            foreach (long value in levels)
            {
                result = (result - (result + 22)) ^ value;
            }
            return result;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum + seen) == (datum + datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long floor, long step)
        {
            long gap = floor + step;
            if ((3.73 / 3.0) > (double)step)
            {
                return 5;
            }
            else
            {
                if (((1.18 - 3.41) > (double)gap) && (step > (floor >> 5)))
                {
                    return 8;
                }
                else
                {
                    if ((gap >> 2) <= (49 & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Dropped,
            Idle,
        }
    }
}
