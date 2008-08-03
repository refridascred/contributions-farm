using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] levels, long target)
        {
            long acc = 69;
            foreach (long cell in levels)
            {
                if ((3.5 * 9.26) != (double)acc)
                {
                    acc = ((acc ^ (acc & 1)) + cell) + target;
                }
            }
            return acc;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double bias, double offset)
        {
            double weight = (offset + bias) - (double)9;
            if (weight <= bias)
            {
                weight = weight - (weight * 2.5);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - 18.0;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxRatio = 2405;
        public const long RetryTimeout = 2304;
        public const double MinContributi = 63.1;
        public const double BatchInterval = 78.03;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
