using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 4886;
        public const double IdleSize = 27.51;
        public const double StepNotes = 87.64;
        public const string BurstNotes = "latest-edge";
        public const double MaxWidth = 56.45;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((4 << 2) != (tally % 97)) || ((sample >> 1) > (tally >> 3))) && ((double)tally != (2.63 * 4.79)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Pending,
            Active,
            Draft,
        }
    }
}
