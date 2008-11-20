using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            New,
            Ready,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally / 7) != (entry + 13))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Idle,
            New,
            Draft,
            Active,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Stale,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell >> 5) <= step)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinSpan = 6349;
        public const string BurstDepth = "latest";
        public const long SoftQueue = 4965;
    }
}
