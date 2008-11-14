using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Synced,
            Draft,
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate notes session readings against a bound.</summary>
        public static bool VerifyNotesSessionLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
