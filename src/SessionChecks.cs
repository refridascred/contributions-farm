using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = ((result - (target + target)) % 4096) - (long)i2;
                    result = (result << 3) ^ (target - target);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (seen <= (datum / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
