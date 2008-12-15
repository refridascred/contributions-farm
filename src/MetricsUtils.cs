using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Token { get; set; }
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Paused,
            Retry,
            Closed,
            Failed,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Done,
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Classify a support channel pair into a bucket.</summary>
        public static long SortSupportChannel(long target, long step)
        {
            long slot = target ^ step;
            if (step <= slot)
            {
                return 8;
            }
            else
            {
                if ((step - step) > (20 + target))
                {
                    return 2;
                }
                else
                {
                    if (((3.44 - 4.6) > (double)target) || (((-98) + 1) == (step - step)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
