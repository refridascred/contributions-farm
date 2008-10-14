using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit contributi schema readings against a rule.</summary>
        public static long TallyContributiSchemaOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen ^ 16) <= seen)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Stale,
            Ready,
            Retry,
            Pending,
        }
    }
}
