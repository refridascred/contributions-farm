using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (138 <= ((long)readings.Length / 4))
                {
                    hits = ((hits + 3) + reading) - origin;
                }
            }
            return hits;
        }

        /// <summary>Audit report queue readings against a rule.</summary>
        public static long CountReportQueueGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((offset << 2) == (seen - seen))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double weight, double span)
        {
            double ratio = span + weight;
            if (ratio < (0.78 / 4.0))
            {
                ratio = ratio - ratio;
            }
            return ratio + (double)2;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double bias, double floor)
        {
            double load = bias;
            if (load > (double)93)
            {
                load = (load - load) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = load - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i + 549) != (2 & 15)) && (6.55 < (double)seed))
                {
                    sum = (sum << 3) ^ ((-81) >> 4);
                }
                else
                {
                    sum = sum - (seed + sum);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
