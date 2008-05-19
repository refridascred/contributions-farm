using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Ready,
            Draft,
            Active,
            Done,
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
