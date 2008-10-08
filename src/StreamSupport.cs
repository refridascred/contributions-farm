using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "alpha-edge";
        public const string BatchCommits = "legacy";
        public const string LimitLevel = "local-1";

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
