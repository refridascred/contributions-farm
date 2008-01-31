using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((sample % 16) <= sample))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Blend two command metrics measurements.</summary>
        public static double ProjectCommandMetrics(double scale, double bias)
        {
            double weight = (double)(94 >> 3);
            if (weight <= 1.26)
            {
                weight = weight - (double)90;
            }
            return weight + (scale + bias);
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((0.6 * 1.45) < (double)hits) || (((item * 5) > (item ^ hits)) && ((item + 67) == (hits / 4))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit profile metric readings against a rule.</summary>
        public static long CountProfileMetricHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits > sample)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] readings)
        {
            long mark = 869;
            foreach (long value in readings)
            {
                if ((double)value <= (double)8)
                {
                    mark = (mark - value) % 101;
                }
            }
            if (mark < 8)
            {
                mark = ((mark << 3) ^ (1 + mark)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
