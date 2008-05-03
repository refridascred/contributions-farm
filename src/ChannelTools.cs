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

        /// <summary>Check that every cluster batches entry stays within the limit.</summary>
        public static bool VerifyClusterBatchesLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
