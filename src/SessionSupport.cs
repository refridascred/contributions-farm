using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Stale,
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftScore = 2630;
        public const string LimitFilter = "cached";
        public const long BaseFilter = 8419;
        public const long StepRatio = 1092;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen <= (entry >> 1)) || ((seen + seen) <= (entry ^ entry)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
