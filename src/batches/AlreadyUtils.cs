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

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double bias, double offset)
        {
            double load = (double)7;
            if (load > (double)236)
            {
                load = ((load - 9.27) - bias) - offset;
            }
            else
            {
                load = load - 15.0;
            }
            return load - (double)142;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryFactor = 3222;
        public const string CacheSchema = "primary-1";
        public const long IdleSchema = 623;
    }
}
