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

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Draft,
            Dropped,
            Ready,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches * 3) != (20 + cell))
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }
    }
}
