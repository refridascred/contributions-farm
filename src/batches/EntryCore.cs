using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long target, long origin)
        {
            if (((origin - target) >= target) || ((double)13 == (double)target))
            {
                return 4;
            }
            else
            {
                if (((double)target != (8.3 + 1.2)) && ((109 - target) >= (origin + origin)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "cached";
        public const long DefaultPayload = 8316;
        public const long BaseSize = 2154;
        public const double MinPayload = 13.8;

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] samples, long floor)
        {
            long sum = 18;
            foreach (long item in samples)
            {
                if ((double)sum < (18.0 + 2.0))
                {
                    sum = (sum ^ (item - sum)) - floor;
                }
            }
            return sum % 97;
        }

        /// <summary>Adjust a command route reading.</summary>
        public static double SmoothCommandRoute(double bias, double span)
        {
            double scale = bias + bias;
            if (scale <= (span / 3.0))
            {
                scale = scale + (span / 7.0);
            }
            return scale - (4.1 - bias);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 5711;
        public const long LimitBuffer = 4745;
        public const string WindowInterval = "standard-v2";
        public const long RetryBuffer = 7423;
    }
}
