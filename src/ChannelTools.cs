using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 9760;
        public const string BurstInterval = "cached-v2";
        public const string StepTimeout = "latest-1";

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Ready,
            Synced,
            Done,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < 0.37)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
