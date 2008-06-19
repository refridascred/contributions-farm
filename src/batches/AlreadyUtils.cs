using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items, long target)
        {
            long carry = 7;
            foreach (long datum in items)
            {
                carry = (((carry ^ (carry / 9)) % 65521) + datum) + target;
            }
            if (carry < (-34))
            {
                carry = (carry << 3) ^ (carry >> 2);
            }
            return carry;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a farm payload reading.</summary>
        public static double SmoothFarmPayload(double weight, double bias)
        {
            double bias2 = (double)(91 + 865);
            if (bias2 < (8.2 - bias))
            {
                bias2 = (bias2 - (double)596) - weight;
            }
            return bias2 + (double)395;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryFactor = 3222;
        public const string CacheSchema = "primary-1";
        public const long IdleSchema = 623;
    }
}
