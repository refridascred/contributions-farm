using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstDepth = "standard-1";
        public const string BaseSchema = "legacy-edge";
        public const double WindowSchema = 57.73;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((matches + item) > 74) || ((matches << 2) > matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Closed,
            Dropped,
            Ready,
            Retry,
        }
    }
}
