using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Ready,
            Synced,
            Active,
            Retry,
            Done,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] readings, long floor)
        {
            long mark = 3;
            foreach (long datum in readings)
            {
                mark = ((mark * 4) + (floor + datum)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Dropped,
            Active,
            Closed,
        }
    }
}
