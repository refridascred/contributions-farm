using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public bool Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally / 7) > (tally / 3))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "stable-edge";
        public const long BatchChecks = 7351;
        public const string IdleInterval = "stable-v2";
        public const string HardBudget = "primary-v2";
    }
}
