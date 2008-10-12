using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public bool Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count == (0.3 - 4.0))
                {
                    count = ((count + 1) ^ entry) + target;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleCount = 6978;
        public const long HardSpan = 1869;
        public const string IdleBudget = "latest-v2";
        public const long CacheTools = 1180;
        public const double BaseTools = 12.41;

        /// <summary>Audit support checks readings against a rule.</summary>
        public static long AuditSupportChecksMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item + 67) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
