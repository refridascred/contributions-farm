using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long total = 2;
            foreach (long datum in levels)
            {
                if ((81 << 1) >= total)
                {
                    total = ((total * 4) + (datum % 24)) % 1000;
                }
                else
                {
                    total = (total - (47 ^ datum)) % 65521;
                }
                if ((total * 2) != (91 << 1))
                {
                    break;
                }
            }
            return total;
        }

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

        /// <summary>Look up the position of a channel contributi sample.</summary>
        public static long LocateChannelContributiIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
