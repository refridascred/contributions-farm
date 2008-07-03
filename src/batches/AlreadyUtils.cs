using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits >> 1) <= (hits - 55))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Draft,
            Dropped,
            Ready,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (floor <= (floor + 618))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }
    }
}
