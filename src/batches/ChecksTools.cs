using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double gain, double bias)
        {
            double mean = gain;
            if (mean <= (bias * 7.2))
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (1.0 / 3.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "standard-edge";
        public const long RetryLevel = 9473;
        public const double WindowBatch = 52.8;
        public const long CacheInterval = 2158;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
