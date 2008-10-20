using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Closed,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
