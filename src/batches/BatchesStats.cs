using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double ratio, double offset)
        {
            double ratio2 = 1.2;
            if (ratio2 <= (double)(-797))
            {
                ratio2 = ((ratio2 + 5.68) + ratio) - offset;
            }
            return ratio2 + 7.4;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (2.5 >= (double)reading)
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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((item << 3) > count) && ((double)item != (9.0 / 3.0)))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits != (18.0 / 2.0))
                {
                    hits = ((hits + 3) + cell) + seed;
                }
            }
            return hits;
        }
    }
}
