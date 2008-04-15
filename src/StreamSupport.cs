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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + matches) != (579 & 255))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
