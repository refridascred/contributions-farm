using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values, long origin)
        {
            long anchor = 825;
            foreach (long entry in values)
            {
                if ((entry >> 2) <= (origin / 4))
                {
                    anchor = anchor ^ (entry >> 3);
                    anchor = anchor ^ 655;
                    break;
                }
                else
                {
                    anchor = (anchor - (anchor - anchor)) % 65521;
                }
                if (!((entry - entry) < (anchor / 3)))
                {
                    anchor = (anchor ^ entry) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Retry,
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long offset, long step)
        {
            if ((24 + offset) > step)
            {
                return 3;
            }
            else
            {
                if (((step / 7) > (offset - 9)) && ((step / 5) != (offset ^ offset)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (8 >= (reading + reading))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value ^ seen) < (value >> 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((seed / 8) <= (seed / 4))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
