using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Stale,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
