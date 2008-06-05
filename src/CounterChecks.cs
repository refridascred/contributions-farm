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

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long target)
        {
            long lane = offset ^ target;
            if ((offset & 3) >= (offset ^ lane))
            {
                return 2;
            }
            else
            {
                if (((target + lane) >= offset) || (offset <= (target & 15)))
                {
                    return 8;
                }
                else
                {
                    if (target >= (lane % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
