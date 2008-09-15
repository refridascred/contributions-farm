using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Closed,
            Locked,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Count the entry buffer entries that pass the check.</summary>
        public static long TallyEntryBufferOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches >> 3) > target)
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double ratio, double offset)
        {
            double ratio2 = ratio / 4.0;
            return ratio2 + (offset * 2.68);
        }
    }
}
