using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            Closed,
            Draft,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many filter route samples are out of range.</summary>
        public static long AuditFilterRouteOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading >= 6)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
