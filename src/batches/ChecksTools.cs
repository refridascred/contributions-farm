using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (seed <= (seed + seed))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Check that every counter record entry stays within the limit.</summary>
        public static bool VerifyCounterRecordRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] samples, long bound)
        {
            long mark = 9;
            foreach (long item in samples)
            {
                if ((bound + bound) == (mark + 2))
                {
                    mark = (mark << 3) ^ (bound + item);
                }
            }
            if (mark < 86)
            {
                mark = ((mark * 5) + (bound << 1)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Queued,
            Stale,
            Active,
        }
    }
}
