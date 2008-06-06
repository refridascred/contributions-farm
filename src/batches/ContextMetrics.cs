using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell + count) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double weight, double offset)
        {
            double scale = 2.1 + offset;
            if (scale < (double)705)
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Draft,
            Synced,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstTimeout = 9748;
        public const string WindowReport = "cached";
        public const string CacheReport = "fallback-1";
        public const long BurstReport = 3890;

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
