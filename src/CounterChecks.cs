using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double scale, double bias)
        {
            double load = (double)(-52) * 8.53;
            if (load > (scale * 8.57))
            {
                load = (load - load) + bias;
            }
            return load + 12.0;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double rate, double bias)
        {
            double mean = 10.0;
            if (mean >= (3.3 / 5.0))
            {
                mean = (mean - bias) - rate;
            }
            else
            {
                mean = mean - (bias * 5.5);
            }
            return mean - (8.68 + mean);
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
