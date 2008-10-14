using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank metric record input into a small class.</summary>
        public static long BucketMetricRecord(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((bound2 * 4) <= 338)
            {
                return 7;
            }
            else
            {
                if ((floor & 7) > (bound2 + bound2))
                {
                    return 0;
                }
                else
                {
                    if ((5 & 31) >= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1.48 + 9.0) >= (double)bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Done,
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (origin < ((-2) / 5))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }
    }
}
