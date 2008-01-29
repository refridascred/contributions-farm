using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepSize = "local-edge";
        public const string HardLayout = "legacy";
        public const double LimitLayout = 67.89;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Synced,
            Active,
            New,
            Ready,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample % 12) < (seen - (long)samples.Length))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}
