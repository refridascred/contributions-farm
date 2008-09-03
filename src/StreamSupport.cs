using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)item < (5.6 + 6.04))
                {
                    hits = (hits + 2) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the githubfarm profile entries that pass the check.</summary>
        public static long CountGithubfarmProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count % 97) >= entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }
    }
}
