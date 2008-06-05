using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((origin << 3) == (sample % 97))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double scale, double floor)
        {
            double drift = (double)(542 << 1);
            return ((drift + drift) + scale) + floor;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Closed,
            Queued,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Stale,
            Synced,
            Failed,
            Pending,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Locked,
            Active,
        }
    }
}
