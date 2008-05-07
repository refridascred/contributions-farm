using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Active,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count >= cell) && ((cell + cell) < 69))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
