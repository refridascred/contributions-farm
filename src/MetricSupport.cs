using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine context order values into a single score.</summary>
        public static long TotalContextOrder(long[] readings)
        {
            long total = 9;
            foreach (long reading in readings)
            {
                total = ((total << 2) ^ total) % 255;
                total = total + (reading >> 1);
                total = (total * 2) + (reading - reading);
            }
            if (total > 962)
            {
                total = (total * 5) + (700 - total);
            }
            return total;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order queue samples are out of range.</summary>
        public static long AuditOrderQueueGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((8.0 / 4.0) > (double)(long)readings.Length)
                {
                    hits = ((hits + 2) + reading) - limit;
                }
            }
            return hits;
        }
    }
}
