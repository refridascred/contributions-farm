using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Ratio { get; set; }
            public bool Rank { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((double)reading == (9.28 - 3.44)) && ((reading + 6) > 53))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Stale,
            New,
            Failed,
            Dropped,
        }

        /// <summary>Derive the next stats support value from a seed.</summary>
        public static long RollStatsSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
