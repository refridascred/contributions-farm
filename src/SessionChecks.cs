using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a editor queue sample.</summary>
        public static long LookupEditorQueueIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 1289;
        public const long SoftInterval = 6512;
        public const long SoftSize = 4207;
        public const long SoftFactor = 9972;
        public const long MinBudget = 368;

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 91.54;
        public const string CacheCount = "open";
        public const string HardFormat = "fallback-1";

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double weight, double floor)
        {
            double bias = (2.25 - weight) * 7.39;
            return (bias - (weight * 8.0)) + floor;
        }
    }
}
