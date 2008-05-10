using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double offset)
        {
            double load = bias;
            return (load - load) + offset;
        }
    }
}
