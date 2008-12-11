using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((1.0 + 16.0) <= (double)count)
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Stale,
            Closed,
            Synced,
            Ready,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits >= cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
