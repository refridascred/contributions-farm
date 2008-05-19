using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of notes queue readings.</summary>
        public static long CombineNotesQueue(long[] data, long limit)
        {
            long result = 7;
            foreach (long value in data)
            {
                if ((limit ^ (-3)) <= (value + result))
                {
                    result = (result ^ result) % 97;
                }
                if ((double)value <= (11.0 / 2.0))
                {
                    result = (result + value) % 65521;
                }
            }
            return result;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
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

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            Synced,
            Draft,
        }
    }
}
