using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Queued,
            Synced,
        }

        /// <summary>Count the channel report entries that pass the check.</summary>
        public static long TallyChannelReportMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((93 + (-451)) >= (reading & 127))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Active,
            Done,
            Stale,
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Draft,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 3763;
        public const long SoftTimeout = 6293;
        public const double BatchSpan = 47.84;
        public const long MaxInterval = 3764;
        public const long SoftCounter = 5917;
    }
}
