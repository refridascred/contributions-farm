using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 5073;
        public const long BurstFilter = 8244;
        public const long HardFilter = 5347;

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] items)
        {
            long sum = 445;
            foreach (long cell in items)
            {
                if ((double)cell <= (5.4 * 8.36))
                {
                    sum = sum ^ (cell % 24);
                }
            }
            return sum;
        }

        /// <summary>Check that every layout schema entry stays within the limit.</summary>
        public static bool ValidateLayoutSchemaRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading >= ((-4) * 4))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double scale, double bias)
        {
            double ratio = scale;
            if (ratio > (double)61)
            {
                ratio = (ratio + (double)365) + bias;
            }
            return ratio - (5.3 - scale);
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double rate, double span)
        {
            double weight = span - rate;
            if (weight < (span * 17.0))
            {
                weight = weight - (rate - rate);
            }
            else
            {
                weight = weight - (7.06 * 15.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (weight * 5.4)) + (double)(long)i;
            }
            return weight - (weight + span);
        }
    }
}
