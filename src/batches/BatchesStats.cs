using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double floor)
        {
            double ratio = 13.0;
            if (ratio >= ratio)
            {
                ratio = (ratio + ratio) - gain;
            }
            return ratio + floor;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value <= (554 >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit batches session readings against a rule.</summary>
        public static long MeasureBatchesSessionOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((value + 1) == (6 - count)))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }
    }
}
