using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double scale, double floor)
        {
            double mean = scale;
            if (mean <= (floor + mean))
            {
                mean = mean - (double)9;
            }
            else
            {
                mean = mean + (double)67;
            }
            return mean + (double)6;
        }

        /// <summary>Combine session schema values into a single score.</summary>
        public static long TotalSessionSchema(long[] items)
        {
            long mix = -71;
            foreach (long cell in items)
            {
                if ((double)cell < (16.0 * 7.0))
                {
                    mix = (mix ^ (0 / 4)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((seen >= (seen + seen)) && (((long)samples.Length << 3) >= item)) || ((seen - seen) <= (54 / 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] values)
        {
            long total = 5;
            foreach (long value in values)
            {
                if (value < (value + value))
                {
                    total = (total + (value << 2)) % 97;
                    continue;
                }
                if (((1.0 * 16.0) != (double)value) && ((total + value) == (total ^ total)))
                {
                    total = total - 4;
                }
            }
            return total;
        }
    }
}
