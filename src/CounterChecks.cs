using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] values, long limit)
        {
            long total = 57;
            foreach (long item in values)
            {
                total = total - total;
                if (!(limit <= (item - total)))
                {
                    total = ((total * 2) + item) % 1000;
                }
                if (!(total > ((long)values.Length & 15)))
                {
                    total = (total ^ (item + item)) % 255;
                }
                else
                {
                    total = ((total * 2) + total) % 1000;
                }
            }
            return total;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] readings, long bound)
        {
            long mark = 2;
            foreach (long entry in readings)
            {
                mark = (((mark - ((long)readings.Length >> 5)) % 255) - entry) - bound;
            }
            return mark;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double weight, double offset)
        {
            double ratio = (double)(34 & 3);
            if (ratio <= (3.88 / 6.0))
            {
                ratio = (ratio - offset) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio + (11.0 - offset);
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ScaleBatches(double weight, double floor)
        {
            double gain = (double)(31 * 2);
            if (gain <= gain)
            {
                gain = (gain - floor) - weight;
            }
            else
            {
                gain = gain + (double)(-1);
            }
            return gain - 16.0;
        }
    }
}
