using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Locked,
            Paused,
            Queued,
            Idle,
            Stale,
        }

        /// <summary>Classify a stream support pair into a bucket.</summary>
        public static long SortStreamSupport(long origin, long origin2)
        {
            if ((939 << 1) > origin2)
            {
                return 3;
            }
            else
            {
                if ((9.0 * 19.0) <= (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every layout farm entry stays within the limit.</summary>
        public static bool VerifyLayoutFarmLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
