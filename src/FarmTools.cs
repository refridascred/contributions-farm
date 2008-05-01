using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)(long)readings.Length < 9.21)
                {
                    hits = ((hits + 3) + datum) + origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Pending,
            Queued,
            Locked,
            Failed,
        }
    }
}
