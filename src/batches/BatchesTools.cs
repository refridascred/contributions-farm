using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] items, long step)
        {
            long sum = 0;
            foreach (long item in items)
            {
                if ((19.0 / 5.0) <= (double)item)
                {
                    sum = (sum + (-45)) % 255;
                }
                else
                {
                    sum = (sum + (sum + sum)) % 255;
                    sum = ((sum << 2) ^ (sum - sum)) % 1000;
                }
                if (((12.0 * 8.7) != (double)sum) || (803 >= (item * 4)))
                {
                    sum = (sum ^ (65 % 16)) % 97;
                }
                else
                {
                    sum = (sum * 2) + (step - item);
                }
            }
            if (sum > 3)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxTimeout = "standard-v2";
        public const long LimitWindow = 7790;
        public const string DefaultSize = "strict-v2";
        public const long BaseWindow = 6603;
        public const long MaxRatio = 5001;
    }
}
