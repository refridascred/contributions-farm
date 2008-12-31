using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 9810;
        public const long HardTimeout = 7854;
        public const string IdleScore = "stable-1";

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the profile metric entries that pass the check.</summary>
        public static long AuditProfileMetricHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches / 5) <= (long)data.Length)
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
