using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the order layout entries that pass the check.</summary>
        public static long TallyOrderLayoutMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((entry + 3) != (seen * 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            New,
            Retry,
            Draft,
        }
    }
}
