using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Dropped,
            Active,
            Idle,
            Closed,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Active,
            New,
            Queued,
            Failed,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] series, long limit)
        {
            long total = 9;
            foreach (long item in series)
            {
                if (!((limit ^ limit) <= limit))
                {
                    total = (total ^ limit) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ item) % 101;
                }
                if (total > (item + item))
                {
                    break;
                }
            }
            return total;
        }
    }
}
