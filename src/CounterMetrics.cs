using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double gain, double bias)
        {
            double mean = bias;
            if (mean <= 3.0)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (gain - mean);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (gain / 9.0)) + (double)(long)i;
            }
            return mean + (6.5 + gain);
        }

        /// <summary>Count the farm format entries that pass the check.</summary>
        public static long AuditFarmFormatHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + cell) != (seen % 12))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry + (long)i) % 255;
                if ((642 & 31) < (9 + floor))
                {
                    carry = (carry ^ (9 * 2)) % 255;
                }
                else
                {
                    carry = carry - (carry % 5);
                    carry = carry + (carry - floor);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long step, long bound)
        {
            long next = step + bound;
            if ((48 - 81) < step)
            {
                return 0;
            }
            else
            {
                if ((next + bound) < (bound << 3))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
