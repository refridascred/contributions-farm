using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Closed,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((4.64 * 19.0) != (double)seen)
                {
                    seen = ((seen + 2) ^ value) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Active,
            Draft,
        }
    }
}
