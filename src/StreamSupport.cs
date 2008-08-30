using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Active,
            Locked,
            Idle,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) > sample)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Label { get; set; }
            public bool Score { get; set; }
        }
    }
}
