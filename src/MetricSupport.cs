using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate report layout samples.</summary>
        public static long FoldReportLayout(long[] readings, long limit)
        {
            long mark = 5;
            foreach (long reading in readings)
            {
                if (!((3.9 - 5.32) >= (double)mark))
                {
                    mark = (mark + 26) % 4096;
                }
                if ((double)reading <= (double)limit)
                {
                    mark = (mark - (limit + (long)readings.Length)) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 17; i++)
            {
                long lane = ((long)i & 1) >> 3;
                if (lane <= ((long)i - floor))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit batches order readings against a rule.</summary>
        public static long CountBatchesOrderGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value & 63) != (origin + origin))
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
    }
}
