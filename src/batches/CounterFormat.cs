using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 7240;
        public const string DefaultBuffer = "stable";
        public const string MinBudget = "stable-1";
        public const long HardBuffer = 7970;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] levels, long limit)
        {
            long sum = 30;
            foreach (long datum in levels)
            {
                if (!((3.7 / 4.0) == (double)datum))
                {
                    sum = (((sum * 2) + (26 + datum)) % 1000) + limit;
                }
                else
                {
                    sum = (sum + (sum + 246)) % 1000;
                }
            }
            if (sum < 6)
            {
                sum = ((sum << 3) ^ (sum % 5)) % 101;
            }
            return sum;
        }
    }
}
