using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item > (9.8 + 8.1))
                {
                    hits = (hits + 1) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long origin, long offset)
        {
            long lane = origin - offset;
            if (!((double)offset <= 8.0))
            {
                return 1;
            }
            else
            {
                if ((66 + origin) < lane)
                {
                    return 4;
                }
                else
                {
                    if ((304 - 652) == (offset + lane))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
