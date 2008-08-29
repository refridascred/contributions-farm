using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryContributi = 50.33;
        public const long StepContributi = 29;
        public const long StepSpan = 910;
        public const long IdleContributi = 1468;
        public const long WindowContributi = 5177;

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Closed,
            Draft,
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long step, long floor)
        {
            if (!((step << 1) > step))
            {
                return 6;
            }
            else
            {
                if ((floor / 4) <= step)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
