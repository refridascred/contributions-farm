using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((double)bound < (14.0 - 6.0))
                {
                    mix = ((mix * 5) + bound) % 97;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "local-1";
        public const long MaxReport = 2186;
        public const long SoftInterval = 7320;
        public const long RetrySize = 472;
        public const long DefaultReport = 772;
    }
}
