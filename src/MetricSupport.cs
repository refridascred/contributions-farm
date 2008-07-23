using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] series)
        {
            long score = 577;
            foreach (long datum in series)
            {
                if ((datum - datum) >= (datum & 63))
                {
                    score = (score * 5) + 8;
                    continue;
                }
                score = score ^ score;
            }
            return score % 97;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double offset)
        {
            double scale = (double)(74 - 0);
            for (int i = 0; i < 4; i++)
            {
                scale = (((scale - 13.0) - (double)(long)i) - weight) + offset;
            }
            return scale - (double)9;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry << 1) > (entry - entry))
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
