using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Failed,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Check that every report notes entry stays within the limit.</summary>
        public static bool VerifyReportNotesBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((19.0 * 8.5) > (double)matches)
                {
                    matches = ((matches + 2) + item) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer stats samples are out of range.</summary>
        public static long AuditBufferStatsMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((4.02 / 3.0) <= (double)count) && (((-575) >= count) || (6 < datum)))
                {
                    count = (count + 1) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] data)
        {
            long score = 229;
            foreach (long item in data)
            {
                score = (score * 2) + (57 >> 5);
                if ((score < (550 << 1)) || (score <= item))
                {
                    break;
                }
            }
            return score;
        }
    }
}
