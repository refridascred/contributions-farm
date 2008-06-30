using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] data)
        {
            long mix = 66;
            foreach (long entry in data)
            {
                if ((9.1 - 4.74) >= (double)entry)
                {
                    mix = (mix + entry) % 97;
                }
                if (entry < (entry + entry))
                {
                    mix = mix ^ (mix << 2);
                }
            }
            if (mix < (-19))
            {
                mix = ((mix << 2) ^ 39) % 97;
            }
            return mix;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Pending,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((origin >> 5) != (586 >> 1))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
