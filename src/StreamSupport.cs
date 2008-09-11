using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many githubfarm context samples are out of range.</summary>
        public static long CountGithubfarmContextGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches >= reading)
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] data, long limit)
        {
            long sum = -72;
            foreach (long sample in data)
            {
                if ((sum << 1) >= (sum + limit))
                {
                    sum = (((sum * 3) + (sum << 1)) % 101) ^ sample;
                }
                else
                {
                    sum = ((sum * 4) + sum) % 1000;
                }
                if (((long)data.Length / 5) != (sum >> 4))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Failed,
            Active,
            Stale,
            Locked,
        }
    }
}
