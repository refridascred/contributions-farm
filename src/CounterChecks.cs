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

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 1803;
        public const string WindowFactor = "legacy-1";
        public const long DefaultTimeout = 8793;
        public const long BaseCluster = 2533;
        public const long IdleCluster = 6866;
    }
}
