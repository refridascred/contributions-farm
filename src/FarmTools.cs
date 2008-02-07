using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)origin < (17.0 / 2.0))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxBudget = 243;
        public const long LimitFactor = 3015;
        public const string WindowScore = "staging-1";

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
