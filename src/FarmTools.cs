using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Queued,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSize = 4326;
        public const long LimitTimeout = 5276;
        public const string BaseWidth = "stable-v2";
        public const string HardSchema = "staging-edge";

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((3 + matches) > (matches * 5))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}
