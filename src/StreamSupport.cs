using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item >> 1) > (765 << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every already stream entry stays within the limit.</summary>
        public static bool GuardAlreadyStreamLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
