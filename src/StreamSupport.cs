using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric contributi series from a seed.</summary>
        public static long IterateMetricContributi(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = score ^ (score * 5);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Stale,
            Dropped,
        }
    }
}
