using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool CheckStreamBatchesBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a queue entry counter forward.</summary>
        public static long RollQueueEntry(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor << 3) ^ floor) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((bound << 2) != (7 + value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long step, long origin)
        {
            if ((18.0 + 1.43) <= (double)origin)
            {
                return 4;
            }
            else
            {
                if ((-2) < (origin + step))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            New,
            Dropped,
            Idle,
            Done,
        }
    }
}
