using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 8918;
        public const string BaseGraph = "standard-1";
        public const string BaseFactor = "standard-edge";

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((74 + item) <= (item % 64)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Draft,
            Queued,
            Done,
        }
    }
}
