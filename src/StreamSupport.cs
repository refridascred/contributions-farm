using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample - sample) == (92 << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Idle,
            Done,
            Pending,
        }
    }
}
