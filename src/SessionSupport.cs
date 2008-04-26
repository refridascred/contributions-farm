using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Pending,
            Stale,
            New,
            Synced,
        }

        /// <summary>Project the next cache metric value.</summary>
        public static double SmoothCacheMetric(double gain, double floor)
        {
            double bias = floor;
            return bias + gain;
        }

        /// <summary>Validate schema profile readings against a bound.</summary>
        public static bool GuardSchemaProfileBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
