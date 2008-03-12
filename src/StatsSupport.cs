using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Pending,
            New,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum & 1) < (datum + 81))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }
    }
}
