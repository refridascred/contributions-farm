using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of session buffer entries.</summary>
        public static long CombineSessionBuffer(long[] samples, long bound)
        {
            long carry = 964;
            foreach (long datum in samples)
            {
                carry = (((carry * 5) + 7) + datum) + bound;
            }
            if (carry < (-990))
            {
                carry = (carry + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double bias, double span)
        {
            double bias2 = 8.0;
            if (bias2 >= span)
            {
                bias2 = (bias2 - (2.33 - 9.2)) + bias;
            }
            else
            {
                bias2 = bias2 - (bias2 * 1.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (bias2 * 4.54)) + (double)(long)i;
            }
            return bias2 - (bias2 * 0.49);
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count & 31) > (count - value))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }
    }
}
