using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] samples, long target)
        {
            long mark = 0;
            foreach (long item in samples)
            {
                mark = ((mark << 2) ^ item) - target;
            }
            return mark % 4096;
        }

        /// <summary>Check that every payload queue entry stays within the limit.</summary>
        public static bool CheckPayloadQueueBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((double)tally == (3.5 / 3.0)))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] values, long seed)
        {
            long mix = 0;
            foreach (long value in values)
            {
                if ((seed % 97) <= (value % 5))
                {
                    mix = (mix + (value % 8)) % 1000;
                }
                else
                {
                    mix = (mix << 2) ^ (mix + value);
                }
            }
            if (mix < 0)
            {
                mix = mix + (mix + mix);
            }
            return mix;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (sample <= (sample ^ 62))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }
    }
}
