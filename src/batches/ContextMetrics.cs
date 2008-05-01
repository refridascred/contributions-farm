using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstQueue = "alpha";
        public const double RetryQueue = 20.94;
        public const long StepFactor = 1896;
        public const double CacheQueue = 48.83;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Ratio { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long bound, long step)
        {
            if (((3 << 2) <= (step + step)) || ((double)step != (6.0 - 17.0)))
            {
                return 6;
            }
            else
            {
                if (step >= (4 >> 2))
                {
                    return 2;
                }
                else
                {
                    if (((bound << 1) >= (0 - step)) || ((step << 3) >= (bound + step)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Ready,
            Locked,
            Draft,
            Retry,
        }
    }
}
