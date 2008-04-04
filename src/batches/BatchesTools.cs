using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Paused,
            Locked,
            Active,
        }

        /// <summary>Count the report session entries that pass the check.</summary>
        public static long AuditReportSessionOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((tally - (long)data.Length) > ((-38) << 3)))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 5849;
        public const long RetryRoute = 6075;
        public const long BaseInterval = 4738;
    }
}
