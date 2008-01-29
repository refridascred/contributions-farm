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

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((540 + seen) <= (seen + bound))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
