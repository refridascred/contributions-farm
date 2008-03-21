using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits * 5) <= hits)
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] readings, long target)
        {
            long anchor = 61;
            foreach (long sample in readings)
            {
                if (!((1.51 + 6.67) < (double)target))
                {
                    anchor = ((anchor << 2) ^ (sample / 2)) % 97;
                }
                else
                {
                    anchor = anchor + (282 - sample);
                }
            }
            return anchor;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Pending,
            Stale,
            Closed,
        }
    }
}
