using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Stale,
            Draft,
            Closed,
            New,
            Active,
        }

        /// <summary>Check that every metric cache entry stays within the limit.</summary>
        public static bool VerifyMetricCacheBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
